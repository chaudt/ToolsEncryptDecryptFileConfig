using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDescryptAI
{
    public class ConfigReader
    {

        private string _path;
        private string _contents;
        private IEnumerable<ItemConfig> _itemConfigs;
        public IEnumerable<ItemConfig> ItemConfigs
        {
            get { return this._itemConfigs; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">Đường dẫn tới file config</param>
        public ConfigReader(string path)
        {
            this._path = path;
            ReadFile();
            _itemConfigs = Retrieval(this._contents);
        }

        private void ReadFile()
        {
            if (this._path.Length == 0)
                throw new Exception("path not empty");

            this._contents = System.IO.File.ReadAllText(this._path);
        }

        public string Json
        {
            get
            {
                return this._contents;
            }
        }

        private bool TryParseArray(string json, out string value)
        {
            if (json.FirstOrDefault().Equals('['))
            {
                value = json;
                return true;
            }

            value = string.Empty;
            return false;
        }
        private bool IsArrayConfig(string json)
        {
            if (json.IndexOf('{') > 0)
            {
                return true;
            }
            return false;
        }
        private IEnumerable<ItemConfig> Retrieval(string json, string key = "", bool isArrayConfig = false)
        {
            // nếu có key thì return 1 item
            // ngược lại return danh sách các item.

            var results = new List<ItemConfig>();
            Dictionary<string, object> dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            foreach (var dicKey in dic.Keys)
            {
                var typeCode = Type.GetTypeCode(dic[dicKey].GetType());
                switch (typeCode)
                {
                    case TypeCode.Double:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.String:
                    case TypeCode.Boolean:
                        results.Add(new ItemConfig(dicKey, dic[dicKey].ToString(), typeCode));
                        break;
                    default:

                        if (TryParseArray(dic[dicKey].ToString(), out string val))
                        {
                            // kiểm tra là array config hay array tham số.
                            if (IsArrayConfig(dic[dicKey].ToString()))
                            {
                                var arrayObjects = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<object>>(dic[dicKey].ToString());
                                var arrayConfigs = new List<ItemArrayConfig>();
                                foreach (var itemObj in arrayObjects)
                                {
                                    arrayConfigs.Add(new ItemArrayConfig(Retrieval(itemObj.ToString(), dicKey,true)));

                                }

                                results.Add(new ItemConfig(dicKey, arrayConfigs, TypeCode.SByte));
                            }
                            else
                            {
                                results.Add(new ItemConfig(dicKey, val, TypeCode.Byte));
                            }
                        }
                        else
                        {
                            results.AddRange(Retrieval(dic[dicKey].ToString(), dicKey));
                        }
                        break;
                }
            }

            if (key.Length == 0 || isArrayConfig)

                return results;

            return new List<ItemConfig> { new ItemConfig(key, results, TypeCode.Object) };

        }


    }
}
