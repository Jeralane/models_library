using System;
using System.Collections.Generic;
using System.Reflection;

namespace ModelsLibrary
{
    internal struct TableStruct
    {
        public Dictionary<string, object> Fields;
        public string Name;
        public string RealName;
        public KeyValuePair<string, int> Id;

        public TableStruct(AbstractModel model)
        {
            // Fields/Columns are the class properties
            Fields = new Dictionary<string, object>();

            Id = new KeyValuePair<string, int>("Id".ToFieldName(), model.Id);
            Type type = model.GetType();
            PropertyInfo[] properties = type.GetProperties();

            // Iterate through class properties using Reflection
            foreach (PropertyInfo property in properties)
            {
                Fields.Add(property.Name.ToFieldName(), property.GetValue(model, null));
            }

            // Table name will be the class name in plural form
            Name = StringHelper.Pluralize(Properties.Settings.Default.FieldNameCasing == "snake_case"
                    ? type.Name.ToSnakeCase()
                    : type.Name);

            RealName = StringHelper.SplitCamelCase(type.Name);
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append("<");
            sb.AppendFormat("#{0}:", Name);
            foreach (var field in Fields)
            {
                sb.AppendFormat(" [{0} => {1}] ", field.Key, field.Value);
            }
            sb.Append(">");

            return sb.ToString();
        }
    }
}
