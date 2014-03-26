using System;
using System.Collections.Generic;

namespace ModelsLibrary.Payroll
{
    internal class CashAdvance : AbstractModel
    {
        private decimal _cashAdvanceAmount;
        private decimal _cashAdvanceMonthly;
        private int _employeeId;
        private string _name;
        private string _remarks;
        private int _startPayroll;
        private DateTime _transactionDate;

        public decimal CashAdvanceAmount
        {
            get { return _cashAdvanceAmount; }
            set { _cashAdvanceAmount = value; OnPropertyChanged("CashAdvanceAmount"); }
        }

        public decimal CashAdvanceMonthly
        {
            get { return _cashAdvanceMonthly; }
            set { _cashAdvanceMonthly = value; OnPropertyChanged("CashAdvanceMonthly"); }
        }

        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; OnPropertyChanged("EmployeeId"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; OnPropertyChanged("Remarks"); }
        }

        public int StartPayroll
        {
            get { return _startPayroll; }
            set { _startPayroll = value; OnPropertyChanged("StartPayroll"); }
        }

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; OnPropertyChanged("TransactionDate"); }
        }

        public static LinkedList<CashAdvance> GetAll()
        {
            var collection = new LinkedList<CashAdvance>();
            const string sql = "SELECT * FROM CashAdvances";
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var item = new CashAdvance();
                item.SetPropertiesFromDataRow(dataRow);
                collection.AddLast(item);
            }

            return collection;
        }
    }
}
