using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLibrary
{
    public class ModelCreator
    {
        public static string Create(string className) {
            var query = "SHOW FIELDS FROM " + StringHelper.Pluralize(className.ToFieldName());
            var dataTable = DatabaseController.ExecuteSelectQuery(query);

            var tab = "\t";
            var classBuilder = new StringBuilder();
            classBuilder.AppendLine("using System;");
            classBuilder.AppendLine("using System.Collections.ObjectModel;");
            classBuilder.AppendLine();
            classBuilder.AppendLine("namespace ModelsLibrary." + StringHelper.ToPropertyName(Properties.Settings.Default.DatabaseName));
            classBuilder.AppendLine("{");
            classBuilder.AppendLine(string.Format("{0}public partial class {1} : AbstractModel","\t", className.ToPropertyName()));
            classBuilder.AppendLine(tab + "{");

            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var fieldName = dataRow["Field"].ToString();
                if ( fieldName.ToLower() == "id") continue;

                var fieldDef = dataRow["Type"].ToString();
                var fieldType = fieldDef.Split('(')[0];

                var propType = "string";

                switch (fieldType)
                {
                    case "tinyint": propType = "sbyte"; break;
                    case "smallint": propType = "short"; break;
                    case "int": propType = "int"; break;
                    case "bigint": propType = "long"; break;

                    case "bit": propType = "bool"; break;
 
                    case "date": propType = "DateTime"; break;
                    case "datetime": propType = "DateTime"; break;
                    case "datetime2": propType = "DateTime"; break;
                    case "smalldatetime": propType = "DateTime"; break;
                    case "timestamp": propType = "DateTime"; break;

                    case "time": propType = "TimeSpan"; break;

                    case "datetimeoffset": propType = "DateTimeOffset"; break;

                    case "float": propType = "float"; break;
                        
                    case "decimal": propType = "decimal"; break;
                    case "money": propType = "decimal"; break;
                    case "numeric": propType = "decimal"; break;
                    case "smallmoney": propType = "decimal"; break;

                    case "double": propType = "double"; break;
                    case "real": propType = "double"; break;

                    case "binary": propType = "byte[]"; break;
                    case "image": propType = "byte[]"; break;
                    case "varbinary": propType = "byte[]"; break;

                    case "nchar": propType = "char"; break;

                    case "char": propType = "string"; break;
                    case "varchar": propType = "string"; break;
                    case "ntext": propType = "string"; break;
                    case "nvarchar": propType = "string"; break;
                    case "text": propType = "string"; break;

                    case "uniqueidentifier": propType = "Guid"; break;

                    default:
                        propType = "object";
                        break;
                }

                var privateField = "_" + fieldName.ToLowerFirstLetter();
                var publicField = fieldName.ToPropertyName();

                classBuilder.AppendLine(tab + tab + "private " + propType + " " + privateField + ";");
                classBuilder.AppendLine(tab + tab + "public  " + propType + " " + publicField);
                classBuilder.AppendLine(tab + tab + "{");
                classBuilder.AppendLine(tab + tab + tab + "get { return " + privateField + "; }");
                classBuilder.AppendLine(tab + tab + tab + "set { " + privateField + " = value; OnPropertyChanged(\"" + publicField +"\"); }");
                classBuilder.AppendLine(tab + tab + "}");
                classBuilder.AppendLine();
            }

            classBuilder.AppendLine(tab + "}");
            classBuilder.AppendLine();
            classBuilder.AppendLine(tab + "public class " + className + "Collection : ObservableCollection<" + className + ">{ }");
            classBuilder.AppendLine();
            classBuilder.AppendLine("}");

            // create a file
            var path = Environment.CurrentDirectory;
            var tempFile = System.IO.Path.Combine(path, className + ".cs");
            System.IO.File.WriteAllText(tempFile, classBuilder.ToString());

            // return filename
            return tempFile;
        }
    }
}
