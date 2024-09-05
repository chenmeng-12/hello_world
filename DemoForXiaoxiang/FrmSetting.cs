using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBusiness;
using Newtonsoft.Json;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace DemoForXiaoxiang
{
    public partial class FrmSetting : Form
    {
        private static readonly string Path = Environment.CurrentDirectory + "\\配方";
        Formula formula;
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                Invoke((Action)(() =>
                {
                    tscbxFormulaList.ComboBox.DataSource = FormulaManager.FormulaNames.Values.ToList();
                    if (FormulaManager.FormulaNames.Count >= 0)
                    {
                        tscbxFormulaList.ComboBox.SelectedIndex = 0;
                        formula = FormulaManager.Select((string)tscbxFormulaList.SelectedItem) as Formula;
                    }
                    else
                        formula = new Formula();

                    tvwMain.Nodes[0].Nodes.Clear();

                    //var properties = typeof(Formula).GetProperties();
                    foreach (var property in formula.GetType().GetProperties())
                    {
                        DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)property.
                        GetCustomAttributes(typeof(DisplayNameAttribute), true)[0];
                        tvwMain.Nodes[0].Nodes.Add(displayNameAttribute.DisplayName);
                    }
                    //相机
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tvwMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent != null)
                {
                    foreach (var item in formula.GetType().GetProperties())
                    {
                        DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)item.
                       GetCustomAttributes(typeof(DisplayNameAttribute), true)[0];
                        if (displayNameAttribute.DisplayName == e.Node.Text)
                        {
                            pgdMain.SelectedObject = item.GetValue(formula, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string SelectFormula
        {
            get
            {
                if (tscbxFormulaList.ComboBox.SelectedItem == null) return "";
                return (string)tscbxFormulaList.ComboBox.SelectedItem;
            }
        }

        private void tscbxFormulaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFormula == "")
            {
                return;
            }
            formula = FormulaManager.Select((string)tscbxFormulaList.SelectedItem) as Formula;
            tvwMain.ExpandAll();
            pgdMain.SelectedObject = null;
        }

        /// <summary>
        ///     创建配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            if (!CreateNewFormula(out var path))
            {
                return;
            }
            FormulaManager.Create(path.Item1, path.Item2);
            tscbxFormulaList.ComboBox.DataSource = FormulaManager.FormulaNames.Values.ToList();
            tscbxFormulaList.SelectedItem = path.Item2;
            formula = FormulaManager.Select((string)tscbxFormulaList.SelectedItem) as Formula;
        }

        protected static bool CreateNewFormula(out (byte, string) path)
        {
            path = (0, "");
            var frmCreateFormula = new FrmCreateFormula();
            if (frmCreateFormula.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            if (frmCreateFormula.Index == 0 || frmCreateFormula.FormulaName == "")
            {
                MessageBox.Show(@"配方ID或配方名非法！");
                return false;
            }
            path = (frmCreateFormula.Index, $"{frmCreateFormula.Index}_{frmCreateFormula.FormulaName}");
            return !FormulaManager.FormulaNames.ContainsKey(frmCreateFormula.Index);

        }
        /// <summary>
        ///     从指定路径保存配方
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        private void SaveFormula(string path, string fileName)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var textWriter = new StringWriter();
            var jsonWriter = new JsonTextWriter(textWriter)
            {
                Formatting = Formatting.Indented,//格式化缩进
                Indentation = 4,//缩进4个字符
                IndentChar = ' ', //缩进字符为空格
            };
            var serializer = new JsonSerializer();
            serializer.Serialize(jsonWriter, formula);
            File.WriteAllText(path + "\\" + fileName, textWriter.ToString());

        }

        private void tsbtnSvae_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show($@"是否保存配方" + $@"{tscbxFormulaList.ComboBox.Text}", "提示", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    FormulaManager.Update(tscbxFormulaList.ComboBox.Text, formula);
                    MessageBox.Show("保存成功");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectFormula == "")
            {
                return;
            }
            var result = MessageBox.Show($@"配方文件 {SelectFormula} 将被删除.", "提示", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            File.Delete(Path + "\\" + SelectFormula + ".json");
            tscbxFormulaList.ComboBox.DataSource = FormulaManager.FormulaNames.Values.ToList();
            if (FormulaManager.FormulaNames.Count != 0)
            {
                tscbxFormulaList.ComboBox.SelectedIndex = 0;
            }
        }

        #region 打开图片


        protected readonly List<string> ImageFileName = new List<string>();
        private void tsbtnOpenImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = @"图片文件(*.jpg;*.jpeg;*.bmp;*.png;*.tiff)|*.jpg;*.jpeg;*.bmp;*.png;*.tiff",
                Title = @"请选择图片",
                Multiselect = true,
                CheckFileExists = true,
                RestoreDirectory = true,
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var count = lvMain.Items.Count;
            ImageFileName.AddRange(ofd.FileNames);
            imageList1.Images.AddRange(ofd.FileNames.Select(Image.FromFile).ToArray());

            lvMain.BeginUpdate();
            lvMain.Items.Clear();
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                var item = new ListViewItem
                {
                    ImageIndex = i,
                    Text = new FileInfo(ImageFileName[i]).Name,
                };
                lvMain.Items.Add(item);
            }

            lvMain.EndUpdate();
            tslblTotal.Text = lvMain.Items.Count.ToString();

            SelectImage(count);
        }

        private void SelectImage(int index)
        {
            if (ImageFileName.Count == 0) return;
            if (index < 0)
            {
                SelectImage(0);
                return;
            }
            if (index >= lvMain.Items.Count)
            {
                SelectImage(lvMain.Items.Count - 1);
                return;
            }

            tstxtIndex.Text = (index + 1).ToString();


            //pictureBox1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
            imageView1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
        }
        #endregion

        private void tsbtnClearImage_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = null;
            imageView1.Image = null;
            ImageFileName.Clear();
            imageList1.Images.Clear();
            lvMain.BeginUpdate();
            lvMain.Items.Clear();
            lvMain.EndUpdate();
        }

        private void tsbtnFirst_Click(object sender, EventArgs e)
        {
            SelectImage(0);
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            SelectImage(imageList1.Images.Count - 1);
        }

        private void tsbtnPre_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tstxtIndex.Text, out var index))
            {
                return;
            }
            SelectImage(index - 2);
        }

        private void tsbtnLast_Click(object sender, EventArgs e)
        {
            SelectImage(imageList1.Images.Count - 1);
        }
        /// <summary>
        ///     选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedIndices.Count == 0) return;
            var index = lvMain.SelectedIndices[0];
            lvMain.EnsureVisible(index);
            tstxtIndex.Text = (index + 1).ToString();
            //pictureBox1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
            imageView1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
        }

        private void tstxtIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(tstxtIndex.Text, out var index))
                {
                    return;

                }
                SelectImage(index - 1);
            }
        }
    }
}
