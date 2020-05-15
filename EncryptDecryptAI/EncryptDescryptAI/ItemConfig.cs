using System;
using System.Collections.Generic;
using System.Linq;

namespace EncryptDescryptAI
{
    public class ItemConfigKeyVal
    {
        public string Key { get; set; }

        public object Value { get; set; }
    }
    public enum ConfigValueTypes
    {
        NONE = 0,
        STRING,
        OBJECT,
        ARRAY
    }
    public class ItemArrayConfig
    {
        public IEnumerable<ItemConfig> ValueItems { get; private set; }
        public ItemArrayConfig(IEnumerable<ItemConfig> items)
        {
            this.ValueItems = items;
        }
    }
    public class ItemConfig
    {
        /// <summary>
        /// Key của config
        /// </summary>
        public string Key { get; private set; }
        /// <summary>
        /// Giá trị kiểu string của config
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Giá trị kiểu object của config
        /// </summary>
        public IEnumerable<ItemConfig> ValueItems { get; private set; }
        public IEnumerable<ItemArrayConfig> ValueArrayItems { get; private set; }
        public ConfigValueTypes ConfigValueType
        {
            get
            {
                if (this.ValueItems != null && this.ValueItems.Any()) return ConfigValueTypes.OBJECT;

                if (this.ValueArrayItems != null && this.ValueArrayItems.Any()) return ConfigValueTypes.ARRAY;

                return ConfigValueTypes.STRING;
            }
        }
        public TypeCode TypeCode { get; private set; }
        /// <summary>
        /// Cờ đánh dấu trường này có được mã hóa hay không?
        /// </summary>
        public bool IsFlagDecrypt { get; private set; }
        public void SetDecrypt(string valDecrypt)
        {
            this.IsFlagDecrypt = true;
            this.Value = valDecrypt;
        }
        public void SetDecrypt(IEnumerable<ItemConfig> itemsDecrypt)
        {
            this.IsFlagDecrypt = true;
            this.ValueItems = itemsDecrypt;
        }
        public void SetDecrypt(IEnumerable<ItemArrayConfig> itemsDecrypt)
        {
            this.IsFlagDecrypt = true;
            this.ValueArrayItems = itemsDecrypt;
        }
        public void SetEncrypt(string valEncrypt)
        {
            SetDecrypt(valEncrypt);
        }
        public void SetEncrypt(IEnumerable<ItemConfig> itemsEncrypt)
        {
            SetDecrypt(itemsEncrypt);
        }
        public void SetEncrypt(IEnumerable<ItemArrayConfig> itemsEncrypt)
        {
            SetDecrypt(itemsEncrypt);
        }

        public ItemConfig(string key, string val, TypeCode type)
        {
            this.Key = key;
            this.Value = val;
            this.IsFlagDecrypt = false;
            this.TypeCode = type;
        }
        public ItemConfig(string key, IEnumerable<ItemConfig> item, TypeCode type)
        {
            this.Key = key;
            this.ValueItems = item;
            this.IsFlagDecrypt = false;
            this.TypeCode = type;
        }
        public ItemConfig(string key, IEnumerable<ItemArrayConfig> items, TypeCode type)
        {
            this.Key = key;
            this.ValueArrayItems = items;
            this.IsFlagDecrypt = false;
            this.TypeCode = type;
        }
        internal void TryDecrypt(string secureKey)
        {
            var item = Decrypt(this, secureKey, true);
            switch (this.ConfigValueType)
            {
                case ConfigValueTypes.OBJECT:
                    this.ValueItems = item.ValueItems;
                    break;
                case ConfigValueTypes.ARRAY:
                    this.ValueArrayItems = item.ValueArrayItems;
                    break;
                case ConfigValueTypes.STRING:
                    this.Value = item.Value;
                    break;
                default:
                    break;
            }
        }
        internal void TryEncrypt(string secureKey)
        {
            var item = Encrypt(this, secureKey, true);
            switch (this.ConfigValueType)
            {
                case ConfigValueTypes.OBJECT:
                    this.ValueItems = item.ValueItems;
                    break;
                case ConfigValueTypes.ARRAY:
                    this.ValueArrayItems = item.ValueArrayItems;
                    break;
                case ConfigValueTypes.STRING:
                    this.Value = item.Value;
                    break;
                default:
                    break;
            }
        }
        private ItemConfig Decrypt(ItemConfig item, string secureKey, bool isFirstLoop = false)
        {
            var itemLocal = item;
            switch (item.ConfigValueType)
            {
                case ConfigValueTypes.STRING:
                    var key = isFirstLoop ? FindKey(item.Key, secureKey, isFirstLoop) : secureKey;
                    if (SecurityUtil.TryDecrypt(item.Value, key, out string txtDecrypt))
                    {
                        itemLocal.SetDecrypt(txtDecrypt);
                        return itemLocal;
                    }
                    break;
                case ConfigValueTypes.OBJECT:
                    var res = new List<ItemConfig>();
                    foreach (var itemCf in item.ValueItems)
                    {
                        key = FindKey(item.Key + ":" + itemCf.Key, secureKey, isFirstLoop);
                        // những lần sau thì mặc định isFirstLoop=false để chỉ dùng format <pathKey>:<key>,
                        // với pathKey là key được cộng dồn cho tới thời điểm hiện tại
                        res.Add(Decrypt(itemCf, key));
                    }

                    itemLocal.SetDecrypt(res);

                    return itemLocal;
                case ConfigValueTypes.ARRAY:

                    var resArrays = new List<ItemArrayConfig>();
                    foreach (var itemArray in item.ValueArrayItems)
                    {
                        var tmpItemConfigs = new List<ItemConfig>();
                        foreach (var itemCf in itemArray.ValueItems)
                        {
                            key = FindKey(itemCf.Key, secureKey, isFirstLoop);
                            tmpItemConfigs.Add(Decrypt(itemCf, key));
                        }

                        // những lần sau thì mặc định isFirstLoop=false để chỉ dùng format <pathKey>:<key>,
                        // với pathKey là key được cộng dồn cho tới thời điểm hiện tại
                        resArrays.Add(new ItemArrayConfig(tmpItemConfigs));
                    }

                    itemLocal.SetDecrypt(resArrays);

                    return itemLocal;
                default:
                    return itemLocal;
            }
            return itemLocal;
        }
        private ItemConfig Encrypt(ItemConfig item, string secureKey, bool isFirstLoop = false)
        {
            var itemLocal = item;
            switch (item.ConfigValueType)
            {
                case ConfigValueTypes.STRING:
                    if (item.IsFlagDecrypt)
                    {
                        var key = isFirstLoop ? FindKey(item.Key, secureKey, isFirstLoop) : secureKey;
                        if (SecurityUtil.TryEncrypt(item.Value, key, out string txtDecrypt))
                        {
                            itemLocal.SetEncrypt(txtDecrypt);
                            return itemLocal;
                        }
                    }
                    break;
                case ConfigValueTypes.OBJECT:
                    var res = new List<ItemConfig>();
                    foreach (var itemCf in item.ValueItems)
                    {
                        var key = FindKey(item.Key + ":" + itemCf.Key, secureKey, isFirstLoop);
                        // những lần sau thì mặc định isFirstLoop=false để chỉ dùng format <pathKey>:<key>,
                        // với pathKey là key được cộng dồn cho tới thời điểm hiện tại
                        res.Add(Encrypt(itemCf, key));
                    }

                    itemLocal.SetEncrypt(res);

                    return itemLocal;
                case ConfigValueTypes.ARRAY:

                    var resArrays = new List<ItemArrayConfig>();
                    foreach (var itemArray in item.ValueArrayItems)
                    {
                        var tmpItemConfigs = new List<ItemConfig>();
                        foreach (var itemCf in itemArray.ValueItems)
                        {
                           var key = FindKey(itemCf.Key, secureKey, isFirstLoop);
                            tmpItemConfigs.Add(Encrypt(itemCf, key));
                        }

                        // những lần sau thì mặc định isFirstLoop=false để chỉ dùng format <pathKey>:<key>,
                        // với pathKey là key được cộng dồn cho tới thời điểm hiện tại
                        resArrays.Add(new ItemArrayConfig(tmpItemConfigs));
                    }

                    itemLocal.SetEncrypt(resArrays);

                    return itemLocal;
                default:
                    return itemLocal;
            }
            return itemLocal;
        }
        private string FindKey(string key, string secureKey, bool isFirstLoop)
        {
            if (isFirstLoop)
                return $"{secureKey}{key}";

            return $"{secureKey}:{key}";
        }
    }


    public static class ItemConfigExtensions
    {
        public static IEnumerable<KeyVal> RetrievalOnlyKeyVal(this IEnumerable<ItemConfig> itemConfigs)
        {
            var res = new List<KeyVal>();
            // Chỉ lấy object nào có dạng Key val mà thôi, không lấy key object

            foreach (var item in itemConfigs)
            {
                if (item.ConfigValueType == ConfigValueTypes.STRING)
                    res.Add(new KeyVal(item.Key, item.Value));
            }
            return res;
        }
    }
}
