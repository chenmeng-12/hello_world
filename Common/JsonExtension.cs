using System.IO;
using Newtonsoft.Json;

namespace MyCommon
{
    public static class JsonExtension
    {
        private static readonly JsonSerializerSettings JsonSetting;

        static JsonExtension()
        {
            JsonSetting = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }
       
        public static string ToJsonString(this object data)
        {
            return JsonConvert.SerializeObject(data, JsonSetting);
        }

      
        public static string ToJsonString(this object data, params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(data, converters);
        }

       
        public static void SaveToJsonFile(this object data, string filePath)
        {
            var textWriter = new StringWriter();
            var jsonWriter = new JsonTextWriter(textWriter)
            {
                Formatting = Formatting.Indented, //格式化缩进
                Indentation = 4, //缩进4个字符
                IndentChar = ' ' //缩进的字符为空格
            };
            var serializer = new JsonSerializer();
            serializer.Serialize(jsonWriter, data);
            File.WriteAllText(filePath, textWriter.ToString());
        }

      
        public static T GetDeserializeObject<T>(this string data)
        {
            return string.IsNullOrWhiteSpace(data) ? default : JsonConvert.DeserializeObject<T>(data, JsonSetting);
        }

        /// <summary>
        ///     尝试反序列化字符串 失败时返回默认值
        /// </summary>
        /// <typeparam name="T">表示将要反序列化反的对象类型</typeparam>
        /// <param name="data">源字符串</param>
        /// <returns>反序列化对象</returns>
        public static T TryGetDeserializeObject<T>(this string data)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(data, JsonSetting);
            }
            catch (System.Exception)
            {

                //ignore
            }
            return default;
        }

        
        public static T GetDeserializeObject<T>(this string data, params JsonConverter[] converters)

        {
            return string.IsNullOrWhiteSpace(data) ? default : JsonConvert.DeserializeObject<T>(data, converters);
        }

       
        public static T GetMembereiseCopy<T>(this T data)
        {
            return data.ToJsonString().GetDeserializeObject<T>();
        }

      
        public static T ReadObjFromJson<T>(string path)
        {
            if (path == null) return System.Activator.CreateInstance<T>();
            var jsonModel = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            return jsonModel;
        }
    }
}
