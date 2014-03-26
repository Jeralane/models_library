using System;
using System.Collections.ObjectModel;

namespace ModelsLibrary.CoopDatabase
{
    public class Collector : AbstractModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }

    public static class CollectorsHelper
    {
        public static ObservableCollection<Collector> GetAll()
        {
            var collection = new ObservableCollection<Collector>();
            const string sql = "SELECT * FROM Collectors";
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var collector = new Collector();
                collector.SetPropertiesFromDataRow(dataRow);
                collection.Add(collector);
            }

            return collection;
        }
    }
}
