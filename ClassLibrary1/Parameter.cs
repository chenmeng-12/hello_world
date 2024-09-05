using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForForm
{
    public class ParameterManager
    {
        private static readonly string Path = Environment.CurrentDirectory + "\\参数";

        public static Dictionary<byte, string> FormulaNames => new DirectoryInfo(Path).GetFiles("*.json", SearchOption.AllDirectories)
            .ToDictionary(v => byte.Parse(v.Name.Substring(0, v.Name.IndexOf('_'))), v => v.Name.Substring(0, v.Name.LastIndexOf('.')));

        public static Parameter Select(byte index)
        {
            return GetFormula(index);
        }

        public static Parameter Select(string name)
        {
            return GetFormula(name);
        }
        private static Parameter GetFormula(byte index)
        {
            var formulaNmae = FormulaNames[index];
            var path = Path + $"\\{formulaNmae}.json";
            var content = File.ReadAllText(path);
            return content.GetDeserializeObject<Parameter>();
        }

        public static Parameter GetFormula(string name)
        {
            var path = Path + $"\\{name}.json";
            var content = File.ReadAllText(path);
            return content.GetDeserializeObject<Parameter>();
        }

        public static void Create(byte index, string name)
        {
            Parameter parameter = new Parameter();
            FormulaNames.Add(index, name);
            
            string path = Path + "\\" + name + ".json";
            SaveFormula(path, parameter);
        }

       
        public static void Update(string name, Parameter parameter)
        {
            string path = Path + "\\" + name + ".json";
            SaveFormula(path, parameter);
        }

        private static void SaveFormula(string path, Parameter parameter)
        {
            try
            {
                parameter.SaveToJsonFile(path);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class Parameter
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
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string SavePath { get; set; } = @"./Test";

            [DisplayName("白保存文件夹"), Category("地址设置")]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string WhiteFolder { get; set; } = @"./Test";

            [DisplayName("黑保存文件夹"), Category("地址设置")]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            //[TypeConverter(typeof(DirectoryAddressUITypeEditor))]
            public string BlackFolder { get; set; } = @"./Test";

            [DisplayName("置信度"), Category("参数设置")]
            public int Threshold { get; set; }


        }

        public class ObjectDetect
        {
            [DisplayName("图像文件夹"), Category("地址设置")]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string ImageFolder { get; set; } = @"./Test";
        }

        public class ClassPredict
        {
            [DisplayName("图像文件夹"), Category("地址设置")]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string ImageFolder { get; set; } = @"./Test";

            [DisplayName("保存地址"), Category("地址设置")]
            [Editor(typeof(DirectoryAddressUITypeEditor), typeof(UITypeEditor))]
            public string SavePath { get; set; } = @"./Test";
        }
        public class DirectoryAddressUITypeEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.Modal;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                if (value is string)
                {
                    var frm = new FolderBrowserDialog();
                    if (frm.ShowDialog() == DialogResult.OK) return frm.SelectedPath;
                    return value;
                }
                return base.EditValue(context, provider, value);
            }
        }
    }
}
