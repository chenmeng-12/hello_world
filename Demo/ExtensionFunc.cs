using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Demo
{
    public static class ExtensionFunc
    {
        private static readonly JsonSerializerSettings JsonSetting;

        static ExtensionFunc()
        {
            JsonSetting = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }


        public static void SaveToJsonFile(this object data, string filePath)
        {
            var textWriter = new StringWriter();
            var jsonWriter = new JsonTextWriter(textWriter)
            {
                Formatting = Formatting.Indented, 
                Indentation = 4, 
                IndentChar = ' ' 
            };
            var serializer = new JsonSerializer();
            serializer.Serialize(jsonWriter, data);
            File.WriteAllText(filePath, textWriter.ToString());
        }


        public static T GetDeserializeObject<T>(this string data)
        {
            return string.IsNullOrWhiteSpace(data) ? default : JsonConvert.DeserializeObject<T>(data, JsonSetting);
        }
    }
}
