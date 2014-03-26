// All model static method can be place here

using System.Data;

namespace ModelsLibrary.Payroll
{

    static class Data
    {
        internal static DataTable CollectAll(AbstractModel model)
        {
            var sql = string.Format("SELECT * FROM {0}", model.TableName());
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            return dataTable;
        }
    }


    // TaxGroup Static Methods
    public partial class TaxGroup
    {
        public static TaxGroup Find(int id)
        {
            TaxGroup model = new TaxGroup();
            model.Read(id);
            return model;
        }

        public static TaxGroupCollection All()
        {
            var collection = new TaxGroupCollection();
            var model = new TaxGroup();

            var dataTable = Data.CollectAll(model);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var item = new TaxGroup();
                item.SetPropertiesFromDataRow(dataRow);
                collection.Add(item);
            }

            return collection;
        }


    }

    #region --- PhilhealthContribution Static Methods ---

    public partial class PhilhealthContribution
    {
        public static PhilhealthContribution Find(int id)
        {
            PhilhealthContribution model = new PhilhealthContribution();
            model.Read(id);
            return model;
        }

        public static PhilhealthContributionCollection All()
        {
            var collection = new PhilhealthContributionCollection();
            var model = new PhilhealthContribution();

            var dataTable = Data.CollectAll(model);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var item = new PhilhealthContribution();
                item.SetPropertiesFromDataRow(dataRow);
                collection.Add(item);
            }

            return collection;
        }


    }

    #endregion

    #region --- SssContribution Static Methods ---

    public partial class SssContribution
    {
        public static SssContribution Find(int id)
        {
            SssContribution model = new SssContribution();
            model.Read(id);
            return model;
        }

        public static SssContributionCollection All()
        {
            var collection = new SssContributionCollection();
            var model = new SssContribution();

            var dataTable = Data.CollectAll(model);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var item = new SssContribution();
                item.SetPropertiesFromDataRow(dataRow);
                collection.Add(item);
            }

            return collection;
        }


    }

    #endregion



}
