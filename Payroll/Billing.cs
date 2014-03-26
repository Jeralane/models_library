using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ModelsLibrary.Payroll
{
    public class Billing : AbstractModel
    {
        private string _billingType;
        private int _billingNumber;
        private int _detachmentId;
        private int _payrollPeriodId;
        private decimal _monthlyContractAmount;
        private decimal _agencyFee;
        private decimal _agencyFeeVat;
        private decimal _agencyFeeTotal;
        private decimal _ewt;
        private decimal _netAgencyFee;
        private decimal _totalEmployeeSalary;
        private decimal _totalAmountCollectable;

        public string BillingType
        {
            get { return _billingType; }
            set { _billingType = value; OnPropertyChanged("BillingType"); }
        }

        public int BillingNumber
        {
            get { return _billingNumber; }
            set { _billingNumber = value; OnPropertyChanged("BillingNumber"); }
        }

        public int DetachmentId
        {
            get { return _detachmentId; }
            set { _detachmentId = value; OnPropertyChanged("DetachmentId"); }
        }

        public int PayrollPeriodId
        {
            get { return _payrollPeriodId; }
            set { _payrollPeriodId = value; OnPropertyChanged("PayrollPeriodId"); }
        }

        public decimal MonthlyContractAmount
        {
            get { return _monthlyContractAmount; }
            set { _monthlyContractAmount = value; OnPropertyChanged("MonthlyContractAmount"); }
        }

        public decimal AgencyFee
        {
            get { return _agencyFee; }
            set { _agencyFee = value; OnPropertyChanged("AgencyFee"); }
        }

        public decimal AgencyFeeVat
        {
            get { return _agencyFeeVat; }
            set { _agencyFeeVat = value; OnPropertyChanged("AgencyFeeVat"); }
        }

        public decimal AgencyFeeTotal
        {
            get { return _agencyFeeTotal; }
            set { _agencyFeeTotal = value; OnPropertyChanged("AgencyFeeTotal"); }
        }

        public decimal EWT
        {
            get { return _ewt; }
            set { _ewt = value; OnPropertyChanged("EWT"); }
        }

        public decimal NetAgencyFee
        {
            get { return _netAgencyFee; }
            set { _netAgencyFee = value; OnPropertyChanged("NetAgencyFee"); }
        }

        public decimal TotalEmployeeSalary
        {
            get { return _totalEmployeeSalary; }
            set { _totalEmployeeSalary = value; OnPropertyChanged("TotalEmployeeSalary"); }
        }

        public decimal TotalAmountCollectable
        {
            get { return _totalAmountCollectable; }
            set { _totalAmountCollectable = value; OnPropertyChanged("TotalAmountCollectable"); }
        }


        public static LinkedList<Billing> GetAll()
        {
            var collection = new LinkedList<Billing>();
            const string sql = "SELECT * FROM Billings";
            var dataTable = DatabaseController.ExecuteSelectQuery(sql);
            foreach (System.Data.DataRow dataRow in dataTable.Rows)
            {
                var item = new Billing();
                item.SetPropertiesFromDataRow(dataRow);
                collection.AddLast(item);
            }

            return collection;
        }
    }
}
