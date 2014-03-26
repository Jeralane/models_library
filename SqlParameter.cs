namespace ModelsLibrary
{
    public struct SqlParameter
    {
        public string Key;
        public object Value;

        public SqlParameter(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
