using MyCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Windows.Forms;

namespace MyBusiness
{
    public static class FormulaManager
    {
        private static readonly string Path = Environment.CurrentDirectory + "\\配方";

        public static Dictionary<byte, string> FormulaNames => new DirectoryInfo(Path).GetFiles("*.json", SearchOption.AllDirectories)
            .ToDictionary(v => byte.Parse(v.Name.Substring(0, v.Name.IndexOf('_'))), v => v.Name.Substring(0, v.Name.LastIndexOf('.')));


        /// <summary>
        ///     依据索引查找配方
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public static Formula Select(byte index)
        {
            return GetFormula(index);
        }

        public static Formula Select(string name)
        {
            return GetFormula(name);
        }
        /// <summary>
        ///     依据索引返回配方名称
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public static string FormulaName(byte index)
        {
            return FormulaNames[index];
        }

        /// <summary>
        ///     依据索引返回配方
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        private static Formula GetFormula(byte index)
        {
            var formulaNmae = FormulaNames[index];
            var path = Path + $"\\{formulaNmae}.json";
            var content = File.ReadAllText(path);
            return content.GetDeserializeObject<Formula>();
        }

        public static Formula GetFormula(string name)
        {
            //r formulaNmae = FormulaNames[index];
            var path = Path + $"\\{name}.json";
            var content = File.ReadAllText(path);
            return content.GetDeserializeObject<Formula>();
        }

        public static void Create(byte index,string name)
        {
            Formula formula = new Formula();
            FormulaNames.Add(index, name);
            //string path = Path + "\\" + index + "_" + name + ".json";
            string path = Path + "\\" + name + ".json";
            SaveFormula(path, formula);
        }

        /// <summary>
        ///     
        /// </summary>
        /// <param name="name">需要完整的名称</param>
        /// <param name="formula"></param>
        public static void Update(string name,Formula formula)
        {
            string path = Path + "\\" + name + ".json";
            SaveFormula(path, formula);
        }

        private static void SaveFormula(string path,Formula formula)
        {
            try
            {
                formula.SaveToJsonFile(path);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(byte index,string name)
        {
            FormulaNames.Remove(index);
            string path = Path + "\\" + index + "_" + name + ".json";
            File.Delete(path);
        }
    }

    public  class Formula
    {
        [DisplayName("1.自动对焦")]
        public AutoFocus MyAutoFocus { get; set; } = new AutoFocus();

        [DisplayName("2.目标检测")]
        public ObjectDetect MyObjectDetect { get; set; } = new ObjectDetect();


        [DisplayName("3.类别预测")]
        public ClassPredict MyClassPredict { get; set; } = new ClassPredict();

        public class AutoFocus
        {
            [DisplayName("保存地址"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string SavePath { get; set; }= @"./Test";

            [DisplayName("白保存文件夹"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string WhiteFolder { get; set; } = @"./Test";

            [DisplayName("黑保存文件夹"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string BlackFolder { get; set; }= @"./Test";

            [DisplayName("置信度"), Category("参数设置")]
            public int Threshold { get; set; }


        }

        public class ObjectDetect
        {
            [DisplayName("图像文件夹"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string ImageFolder { get; set; } = @"./Test";
        }

        public class ClassPredict
        {
            [DisplayName("图像文件夹"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string ImageFolder { get; set; } = @"./Test";

            [DisplayName("保存地址"), Category("地址设置")]
            [TypeConverter(typeof(HideSizeSubPropConverter))]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string SavePath { get; set; } = @"./Test";
        }
    }

    public class DirectoryAddressUITypeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (value is string )
            {
                var frm = new FolderBrowserDialog();
                if (frm.ShowDialog() == DialogResult.OK) return frm.SelectedPath;
                return value;
            }
            return base.EditValue(context, provider, value);
        }
    }
    public class HideSizeSubPropConverter : TypeConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return false;
        }
    }

    public class JsonAddressUiTypeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal; // 在属性修改框中使用三点样式的选单
        }

        /// <summary>
        ///     单击三点样式选单后弹出文件浏览器选择json格式文件
        /// </summary>
        /// <param name="context"></param>
        /// <param name="provider"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if (value is string || value is null)
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = @"标定文件(*.json)|*.json",
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
                return value;
            }

            return base.EditValue(context, provider, value);
        }
    }
}
