using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDescryptAI
{
    public interface IDecryptEncryptAI : IDisposable
    {
        void ApplyConfig(string json);
    }
    public class DecryptAI : IDecryptEncryptAI
    {
        private readonly string _secureKey;
        private readonly IEnumerable<ItemConfig> _itemConfigs;
        private IEnumerable<ItemConfig> _itemConfigsDescrypt;
        private string _json;
        public string Json
        {
            get
            {
                return this._json;
            }
        }
        public IEnumerable<ItemConfig> ItemConfigsDescrypt
        {
            get
            {
                return this._itemConfigsDescrypt;
            }
        }
        public DecryptAI(string securityKey, IEnumerable<ItemConfig> itemConfigs)
        {
            _secureKey = securityKey;
            _itemConfigs = itemConfigs;

            Decrypt();
            ToJson();
        }
        private ItemConfigKeyVal Convert(ItemConfig item)
        {
            if (item.ConfigValueType != ConfigValueTypes.OBJECT)
                return new ItemConfigKeyVal { Key = item.Key, Value = item.Value };

            var list = new List<ItemConfigKeyVal>();
            foreach (var itemCf in item.ValueItems)
            {
                list.Add(Convert(itemCf));
            }
            return new ItemConfigKeyVal { Key = item.Key, Value = list };
        }
        private string toJson(ItemConfig item, bool isFlag = false)
        {
            switch (item.ConfigValueType)
            {
                case ConfigValueTypes.STRING:
                    switch (item.TypeCode)
                    {
                        case TypeCode.Byte://array
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.Double:
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.Int32:
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.String:
                            return $" \"{item.Key}\": \"{item.Value}\",";

                        case TypeCode.Boolean:
                            return $" \"{item.Key}\":{item.Value.ToLower()},";

                        default:
                            return "";
                    }
                case ConfigValueTypes.OBJECT:
                    var txt = $"\"{item.Key}\":" + "{";
                    int icount = item.ValueItems.Count();
                    foreach (var itemCf in item.ValueItems)
                    {
                        var ji = toJson(itemCf);
                        if (ji.Length != 0)
                        {
                            icount--;
                            if (icount == 0)
                            {
                                ji = ji.Substring(0, ji.Length - 1);
                            }
                        }
                        txt += ji;
                    }
                    txt += "},";
                    return txt;
                case ConfigValueTypes.ARRAY:
                    var txtJson = $"\"{item.Key}\":" + "[";

                    var arrayCount = item.ValueArrayItems.Count();
                    foreach (var itemArray in item.ValueArrayItems)
                    {
                        icount = itemArray.ValueItems.Count();
                        txtJson += "{";
                        foreach (var itemCf in itemArray.ValueItems)
                        {
                            var ji = toJson(itemCf);
                            icount--;
                            if (ji.Length != 0)
                            {

                                if (icount == 0)
                                {
                                    ji = ji.Substring(0, ji.Length - 1);
                                }
                            }
                            txtJson += ji;
                        }
                        txtJson += "},";
                        arrayCount--;
                        if (txtJson.Length != 0)
                        {
                            if (arrayCount == 0)
                            {
                                txtJson.Substring(0, txtJson.Length - 1);
                            }
                        }

                    }
                    txtJson += "],";
                    return txtJson;
                default:
                    return string.Empty;
            }
        }
        private void ToJson()
        {
            var txt = "{";
            foreach (var item in _itemConfigsDescrypt)
            {
                txt += toJson(item);
            }
            txt += "}";


            var objTemp = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(txt);
            this._json = Newtonsoft.Json.JsonConvert.SerializeObject(objTemp, Newtonsoft.Json.Formatting.Indented);
            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(_itemConfigsDescryptKeyVal, Newtonsoft.Json.Formatting.Indented);


            // this._json = "{" + json.Substring(1, json.Length - 2) + "}";

        }
        private void Decrypt()
        {
            //giải mã các chuỗi bị mã hóa bằng key.
            _itemConfigsDescrypt = _itemConfigs;
            foreach (var item in _itemConfigsDescrypt)
            {
                item.TryDecrypt(this._secureKey);
            }
        }

        public void ApplyConfig(string json)
        {
            throw new NotImplementedException();
        }

        #region Dispose

        // Flag: Has Dispose already been called?
        bool disposed;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //

                
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        /// <summary>
        ///     Distroy
        /// </summary>
        ~DecryptAI()
        {
            Dispose(false);
        }

        #endregion
    }
    public class EncryptAI: IDecryptEncryptAI
    {
        #region Dispose

        // Flag: Has Dispose already been called?
        bool disposed;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //


            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        /// <summary>
        ///     Distroy
        /// </summary>
        ~EncryptAI()
        {
            Dispose(false);
        }

        #endregion
        private readonly string _secureKey;
        /// <summary>
        /// Danh sách cấu trúc Item đã được giải mã
        /// </summary>
        private IEnumerable<ItemConfig> _itemConfigs;
        /// <summary>
        /// Danh sách cấu trúc Item đã được mã hóa
        /// Lưu ý rằng các trường được giải mã được đánh dấu cờ IsFlagDecrypt=true.
        /// </summary>
        private readonly IEnumerable<ItemConfig> _itemConfigsDescrypt;
        private string _json;
        public string Json
        {
            get
            {
                return this._json;
            }
        }
        public IEnumerable<ItemConfig> ItemConfigsEncrypt
        {
            get
            {
                return this._itemConfigs;
            }
        }
        public EncryptAI(string securityKey, IEnumerable<ItemConfig> itemConfigsDecrypt)
        {
            this._secureKey = securityKey;
            this._itemConfigsDescrypt = itemConfigsDecrypt;

            Encrypt();
            ToJson();
        }
        private void Encrypt()
        {
            //giải mã các chuỗi bị mã hóa bằng key.
            _itemConfigs = _itemConfigsDescrypt;
            foreach (var item in _itemConfigs)
            {

                item.TryEncrypt(this._secureKey);
            }
        }
        private string toJson(ItemConfig item, bool isFlag = false)
        {
            switch (item.ConfigValueType)
            {
                case ConfigValueTypes.STRING:
                    switch (item.TypeCode)
                    {
                        case TypeCode.Byte://array
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.Double:
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.Int32:
                            return $" \"{item.Key}\":{item.Value},";

                        case TypeCode.String:
                            return $" \"{item.Key}\": \"{item.Value}\",";

                        case TypeCode.Boolean:
                            return $" \"{item.Key}\":{item.Value.ToLower()},";

                        default:
                            return "";
                    }
                case ConfigValueTypes.OBJECT:
                    var txt = $"\"{item.Key}\":" + "{";
                    int icount = item.ValueItems.Count();
                    foreach (var itemCf in item.ValueItems)
                    {
                        var ji = toJson(itemCf);
                        if (ji.Length != 0)
                        {
                            icount--;
                            if (icount == 0)
                            {
                                ji = ji.Substring(0, ji.Length - 1);
                            }
                        }
                        txt += ji;
                    }
                    txt += "},";
                    return txt;
                case ConfigValueTypes.ARRAY:
                    var txtJson = $"\"{item.Key}\":" + "[";

                    var arrayCount = item.ValueArrayItems.Count();
                    foreach (var itemArray in item.ValueArrayItems)
                    {
                        icount = itemArray.ValueItems.Count();
                        txtJson += "{";
                        foreach (var itemCf in itemArray.ValueItems)
                        {
                            var ji = toJson(itemCf);
                            icount--;
                            if (ji.Length != 0)
                            {

                                if (icount == 0)
                                {
                                    ji = ji.Substring(0, ji.Length - 1);
                                }
                            }
                            txtJson += ji;
                        }
                        txtJson += "},";
                        arrayCount--;
                        if (txtJson.Length != 0)
                        {
                            if (arrayCount == 0)
                            {
                                txtJson.Substring(0, txtJson.Length - 1);
                            }
                        }

                    }
                    txtJson += "],";
                    return txtJson;
                default:
                    return string.Empty;
            }
        }
        private void ToJson()
        {
            var txt = "{";
            foreach (var item in _itemConfigs)
            {
                txt += toJson(item);
            }
            txt += "}";


            var objTemp = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(txt);
            this._json = Newtonsoft.Json.JsonConvert.SerializeObject(objTemp, Newtonsoft.Json.Formatting.Indented);

        }

        public void ApplyConfig(string json)
        {
            throw new NotImplementedException();
        }
    }
}
