using System;
using System.Collections.ObjectModel;

namespace ModelsLibrary.Payroll
{
    public partial class Billing : AbstractModel
    {
        private string _billingType;
        public string BillingType
        {
            get { return _billingType; }
            set { _billingType = value; OnPropertyChanged("BillingType"); }
        }

        private int _billingNumber;
        public int BillingNumber
        {
            get { return _billingNumber; }
            set { _billingNumber = value; OnPropertyChanged("BillingNumber"); }
        }

        private int _detachmentId;
        public int DetachmentId
        {
            get { return _detachmentId; }
            set { _detachmentId = value; OnPropertyChanged("DetachmentId"); }
        }

        private int _payrollPeriodId;
        public int PayrollPeriodId
        {
            get { return _payrollPeriodId; }
            set { _payrollPeriodId = value; OnPropertyChanged("PayrollPeriodId"); }
        }

        private decimal _monthlyContractAmount;
        public decimal MonthlyContractAmount
        {
            get { return _monthlyContractAmount; }
            set { _monthlyContractAmount = value; OnPropertyChanged("MonthlyContractAmount"); }
        }

        private decimal _agencyFee;
        public decimal AgencyFee
        {
            get { return _agencyFee; }
            set { _agencyFee = value; OnPropertyChanged("AgencyFee"); }
        }

        private decimal _agencyVatFee;
        public decimal AgencyVatFee
        {
            get { return _agencyVatFee; }
            set { _agencyVatFee = value; OnPropertyChanged("AgencyVatFee"); }
        }

        private decimal _agencyFeeTotal;
        public decimal AgencyFeeTotal
        {
            get { return _agencyFeeTotal; }
            set { _agencyFeeTotal = value; OnPropertyChanged("AgencyFeeTotal"); }
        }

        private decimal _ewt;
        public decimal Ewt
        {
            get { return _ewt; }
            set { _ewt = value; OnPropertyChanged("Ewt"); }
        }

        private decimal _netAgencyFee;
        public decimal NetAgencyFee
        {
            get { return _netAgencyFee; }
            set { _netAgencyFee = value; OnPropertyChanged("NetAgencyFee"); }
        }

        private decimal _totalEmployeeSalary;
        public decimal TotalEmployeeSalary
        {
            get { return _totalEmployeeSalary; }
            set { _totalEmployeeSalary = value; OnPropertyChanged("TotalEmployeeSalary"); }
        }

        private decimal _totalAmountCollectable;
        public decimal TotalAmountCollectable
        {
            get { return _totalAmountCollectable; }
            set { _totalAmountCollectable = value; OnPropertyChanged("TotalAmountCollectable"); }
        }

    }

}
