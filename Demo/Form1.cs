using OpenCvSharp;
using OpenCvSharp.Extensions;
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

namespace Demo
{
    public partial class Form1 : Form
    {
        private static readonly string Path = Environment.CurrentDirectory + "\\参数";
        Parameter parameter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Invoke((Action)(() =>
                {
                    tscbxFormulaList.ComboBox.DataSource = ParameterManager.FormulaNames.Values.ToList();
                    if (ParameterManager.FormulaNames.Count > 0)
                    {
                        tscbxFormulaList.ComboBox.SelectedIndex = 0;
                        parameter = ParameterManager.Select((string)tscbxFormulaList.SelectedItem) as Parameter;
                    }
                    else
                        parameter = new Parameter();

                    tvwMain.Nodes[0].Nodes.Clear();

                    
                    foreach (var property in parameter.GetType().GetProperties())
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            if (!CreateNewFormula(out var path))
            {
                return;
            }
            ParameterManager.Create(path.Item1, path.Item2);
            tscbxFormulaList.ComboBox.DataSource = ParameterManager.FormulaNames.Values.ToList();
            tscbxFormulaList.SelectedItem = path.Item2;
            parameter = ParameterManager.Select((string)tscbxFormulaList.SelectedItem) as Parameter;
        }

        protected static bool CreateNewFormula(out (byte, string) path)
        {
            path = (0, "");
            var createFormula = new CreateParamter();
            if (createFormula.ShowDialog() != DialogResult.OK)
            {
                return false;
            }
            if (createFormula.Index == 0 || createFormula.FormulaName == "")
            {
                MessageBox.Show(@"配方ID或配方名非法！");
                return false;
            }
            path = (createFormula.Index, $"{createFormula.Index}_{createFormula.FormulaName}");
            return !ParameterManager.FormulaNames.ContainsKey(createFormula.Index);

        }

        private void tsbtnSvae_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBoxButtons mess = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show($@"是否保存配方" + $@"{tscbxFormulaList.ComboBox.Text}", "提示", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    ParameterManager.Update(tscbxFormulaList.ComboBox.Text, parameter);
                    MessageBox.Show("保存成功");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SelectParameter
        {
            get
            {
                if (tscbxFormulaList.ComboBox.SelectedItem == null) return "";
                return (string)tscbxFormulaList.ComboBox.SelectedItem;
            }
        }
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectParameter == "")
            {
                return;
            }
            var result = MessageBox.Show($@"配方文件 {SelectParameter} 将被删除.", "提示", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            File.Delete(Path + "\\" + SelectParameter + ".json");
            tscbxFormulaList.ComboBox.DataSource = ParameterManager.FormulaNames.Values.ToList();
            if (ParameterManager.FormulaNames.Count != 0)
            {
                tscbxFormulaList.ComboBox.SelectedIndex = 0;
            }
        }

      

        private void tscbxFormulaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectParameter == "")
            {
                return;
            }
            parameter = ParameterManager.Select((string)tscbxFormulaList.SelectedItem) as Parameter;
            tvwMain.ExpandAll();
            pgdMain.SelectedObject = null;
        }

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

            //pictureBox1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
            imageView1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
        }

        private void tsbtnClearImage_Click(object sender, EventArgs e)
        {
            imageView1.Image = null;
            //imageView1.Image.Dispose();
            ImageFileName.Clear();
            imageList1.Images.Clear();
            lvMain.BeginUpdate();
            lvMain.Items.Clear();
            lvMain.EndUpdate();
        }

        private void tvwMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent != null)
                {
                    foreach (var item in parameter.GetType().GetProperties())
                    {
                        DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)item.
                       GetCustomAttributes(typeof(DisplayNameAttribute), true)[0];
                        if (displayNameAttribute.DisplayName == e.Node.Text)
                        {
                            pgdMain.SelectedObject = item.GetValue(parameter, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedIndices.Count == 0) return;
            var index = lvMain.SelectedIndices[0];
            lvMain.EnsureVisible(index);
            //pictureBox1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
            imageView1.Image = Cv2.ImRead(ImageFileName[index], ImreadModes.AnyColor | ImreadModes.AnyDepth).ToBitmap();
        }

        private void 类别预测ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
