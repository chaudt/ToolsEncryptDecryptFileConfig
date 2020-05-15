namespace EncryptDescryptAI
{
    public class KeyVal
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public KeyVal(string key, string val)
        {
            this.Key = key;
            this.Value = val;
        }
    }
}
