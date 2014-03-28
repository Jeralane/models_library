using System.Collections.ObjectModel;

namespace ModelsLibrary
{
    public static class ModelCollection
    {
        public static ObservableCollection<T> All<T>() where T : AbstractModel, new()
        {
            var item = new T();

            var sql = "SELECT * FROM " + item.TableName();
            var collection = new ObservableCollection<T>();
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var model = new T();
                model.SetPropertiesFromDataRow(dataRow);
                collection.Add(model);
            }
            return collection;
        }
    }
}
