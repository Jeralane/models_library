using System;
using System.Collections.ObjectModel;

namespace ModelsLibrary.Payroll
{
    public partial class Payroll : AbstractModel
    {
        private DateTime _transactionDate;
        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; OnPropertyChanged("TransactionDate"); }
        }

        private int _payrollPeriodId;
        public int PayrollPeriodId
        {
            get { return _payrollPeriodId; }
            set { _payrollPeriodId = value; OnPropertyChanged("PayrollPeriodId"); }
        }

        private int _detachmentId;
        public int DetachmentId
        {
            get { return _detachmentId; }
            set { _detachmentId = value; OnPropertyChanged("DetachmentId"); }
        }

        private int _employeeId;
        public int EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; OnPropertyChanged("EmployeeId"); }
        }

        private decimal _rate;
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; OnPropertyChanged("Rate"); }
        }

        private decimal _cola;
        public decimal Cola
        {
            get { return _cola; }
            set { _cola = value; OnPropertyChanged("Cola"); }
        }

        private decimal _nightDifferentialRate;
        public decimal NightDifferentialRate
        {
            get { return _nightDifferentialRate; }
            set { _nightDifferentialRate = value; OnPropertyChanged("NightDifferentialRate"); }
        }

        private decimal _adjustment;
        public decimal Adjustment
        {
            get { return _adjustment; }
            set { _adjustment = value; OnPropertyChanged("Adjustment"); }
        }

        private decimal _incentives;
        public decimal Incentives
        {
            get { return _incentives; }
            set { _incentives = value; OnPropertyChanged("Incentives"); }
        }

        private decimal _days;
        public decimal Days
        {
            get { return _days; }
            set { _days = value; OnPropertyChanged("Days"); }
        }

        private decimal _hours;
        public decimal Hours
        {
            get { return _hours; }
            set { _hours = value; OnPropertyChanged("Hours"); }
        }

        private decimal _overtimeHours;
        public decimal OvertimeHours
        {
            get { return _overtimeHours; }
            set { _overtimeHours = value; OnPropertyChanged("OvertimeHours"); }
        }

        private decimal _nightDifferentialHours;
        public decimal NightDifferentialHours
        {
            get { return _nightDifferentialHours; }
            set { _nightDifferentialHours = value; OnPropertyChanged("NightDifferentialHours"); }
        }

        private decimal _legalHolidays;
        public decimal LegalHolidays
        {
            get { return _legalHolidays; }
            set { _legalHolidays = value; OnPropertyChanged("LegalHolidays"); }
        }

        private decimal _legalHolidayOvertimeHours;
        public decimal LegalHolidayOvertimeHours
        {
            get { return _legalHolidayOvertimeHours; }
            set { _legalHolidayOvertimeHours = value; OnPropertyChanged("LegalHolidayOvertimeHours"); }
        }

        private decimal _specialHolidays;
        public decimal SpecialHolidays
        {
            get { return _specialHolidays; }
            set { _specialHolidays = value; OnPropertyChanged("SpecialHolidays"); }
        }

        private decimal _specialHolidaysOvertimeHours;
        public decimal SpecialHolidaysOvertimeHours
        {
            get { return _specialHolidaysOvertimeHours; }
            set { _specialHolidaysOvertimeHours = value; OnPropertyChanged("SpecialHolidaysOvertimeHours"); }
        }

        private decimal _basicPay;
        public decimal BasicPay
        {
            get { return _basicPay; }
            set { _basicPay = value; OnPropertyChanged("BasicPay"); }
        }

        private decimal _overtimePay;
        public decimal OvertimePay
        {
            get { return _overtimePay; }
            set { _overtimePay = value; OnPropertyChanged("OvertimePay"); }
        }

        private decimal _nightDifferentialPay;
        public decimal NightDifferentialPay
        {
            get { return _nightDifferentialPay; }
            set { _nightDifferentialPay = value; OnPropertyChanged("NightDifferentialPay"); }
        }

        private decimal _holidayPay;
        public decimal HolidayPay
        {
            get { return _holidayPay; }
            set { _holidayPay = value; OnPropertyChanged("HolidayPay"); }
        }

        private decimal _colaPay;
        public decimal ColaPay
        {
            get { return _colaPay; }
            set { _colaPay = value; OnPropertyChanged("ColaPay"); }
        }

        private decimal _otherPay;
        public decimal OtherPay
        {
            get { return _otherPay; }
            set { _otherPay = value; OnPropertyChanged("OtherPay"); }
        }

        private decimal _grossPayNoIncentives;
        public decimal GrossPayNoIncentives
        {
            get { return _grossPayNoIncentives; }
            set { _grossPayNoIncentives = value; OnPropertyChanged("GrossPayNoIncentives"); }
        }

        private decimal _grossPay;
        public decimal GrossPay
        {
            get { return _grossPay; }
            set { _grossPay = value; OnPropertyChanged("GrossPay"); }
        }

        private decimal _cashAdvanceAmount;
        public decimal CashAdvanceAmount
        {
            get { return _cashAdvanceAmount; }
            set { _cashAdvanceAmount = value; OnPropertyChanged("CashAdvanceAmount"); }
        }

        private decimal _cashAdvance;
        public decimal CashAdvance
        {
            get { return _cashAdvance; }
            set { _cashAdvance = value; OnPropertyChanged("CashAdvance"); }
        }

        private decimal _insurance;
        public decimal Insurance
        {
            get { return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private string _cashBondType;
        public string CashBondType
        {
            get { return _cashBondType; }
            set { _cashBondType = value; OnPropertyChanged("CashBondType"); }
        }

        private decimal _cashBond;
        public decimal CashBond
        {
            get { return _cashBond; }
            set { _cashBond = value; OnPropertyChanged("CashBond"); }
        }

        private byte _cashBondOut;
        public byte CashBondOut
        {
            get { return _cashBondOut; }
            set { _cashBondOut = value; OnPropertyChanged("CashBondOut"); }
        }

        private string _cashBondRemarks;
        public string CashBondRemarks
        {
            get { return _cashBondRemarks; }
            set { _cashBondRemarks = value; OnPropertyChanged("CashBondRemarks"); }
        }

        private decimal _pagibigContributionEmployee;
        public decimal PagibigContributionEmployee
        {
            get { return _pagibigContributionEmployee; }
            set { _pagibigContributionEmployee = value; OnPropertyChanged("PagibigContributionEmployee"); }
        }

        private decimal _pagibigContributionEmployer;
        public decimal PagibigContributionEmployer
        {
            get { return _pagibigContributionEmployer; }
            set { _pagibigContributionEmployer = value; OnPropertyChanged("PagibigContributionEmployer"); }
        }

        private decimal _pagibigContributionTotal;
        public decimal PagibigContributionTotal
        {
            get { return _pagibigContributionTotal; }
            set { _pagibigContributionTotal = value; OnPropertyChanged("PagibigContributionTotal"); }
        }

        private decimal _pagibigLoanAmount;
        public decimal PagibigLoanAmount
        {
            get { return _pagibigLoanAmount; }
            set { _pagibigLoanAmount = value; OnPropertyChanged("PagibigLoanAmount"); }
        }

        private decimal _pagibigLoan;
        public decimal PagibigLoan
        {
            get { return _pagibigLoan; }
            set { _pagibigLoan = value; OnPropertyChanged("PagibigLoan"); }
        }

        private decimal _philhealthContributionEmployee;
        public decimal PhilhealthContributionEmployee
        {
            get { return _philhealthContributionEmployee; }
            set { _philhealthContributionEmployee = value; OnPropertyChanged("PhilhealthContributionEmployee"); }
        }

        private decimal _philhealthContributionEmployer;
        public decimal PhilhealthContributionEmployer
        {
            get { return _philhealthContributionEmployer; }
            set { _philhealthContributionEmployer = value; OnPropertyChanged("PhilhealthContributionEmployer"); }
        }

        private decimal _philhealthContributionTotal;
        public decimal PhilhealthContributionTotal
        {
            get { return _philhealthContributionTotal; }
            set { _philhealthContributionTotal = value; OnPropertyChanged("PhilhealthContributionTotal"); }
        }

        private decimal _sssContributionEmployee;
        public decimal SssContributionEmployee
        {
            get { return _sssContributionEmployee; }
            set { _sssContributionEmployee = value; OnPropertyChanged("SssContributionEmployee"); }
        }

        private decimal _sssContributionEmployer;
        public decimal SssContributionEmployer
        {
            get { return _sssContributionEmployer; }
            set { _sssContributionEmployer = value; OnPropertyChanged("SssContributionEmployer"); }
        }

        private decimal _sssContributionTotal;
        public decimal SssContributionTotal
        {
            get { return _sssContributionTotal; }
            set { _sssContributionTotal = value; OnPropertyChanged("SssContributionTotal"); }
        }

        private decimal _sssLoanAmount;
        public decimal SssLoanAmount
        {
            get { return _sssLoanAmount; }
            set { _sssLoanAmount = value; OnPropertyChanged("SssLoanAmount"); }
        }

        private decimal _sssLoan;
        public decimal SssLoan
        {
            get { return _sssLoan; }
            set { _sssLoan = value; OnPropertyChanged("SssLoan"); }
        }

        private decimal _taxWithheld;
        public decimal TaxWithheld
        {
            get { return _taxWithheld; }
            set { _taxWithheld = value; OnPropertyChanged("TaxWithheld"); }
        }

        private decimal _otherDeductions;
        public decimal OtherDeductions
        {
            get { return _otherDeductions; }
            set { _otherDeductions = value; OnPropertyChanged("OtherDeductions"); }
        }

        private decimal _totalDeductions;
        public decimal TotalDeductions
        {
            get { return _totalDeductions; }
            set { _totalDeductions = value; OnPropertyChanged("TotalDeductions"); }
        }

        private decimal _netPay;
        public decimal NetPay
        {
            get { return _netPay; }
            set { _netPay = value; OnPropertyChanged("NetPay"); }
        }

        private decimal _thirtheenthMonthPay;
        public decimal ThirtheenthMonthPay
        {
            get { return _thirtheenthMonthPay; }
            set { _thirtheenthMonthPay = value; OnPropertyChanged("ThirtheenthMonthPay"); }
        }

        private int _billingId;
        public int BillingId
        {
            get { return _billingId; }
            set { _billingId = value; OnPropertyChanged("BillingId"); }
        }

        private int _miscellaneousBillingId;
        public int MiscellaneousBillingId
        {
            get { return _miscellaneousBillingId; }
            set { _miscellaneousBillingId = value; OnPropertyChanged("MiscellaneousBillingId"); }
        }

        private string _recordStatus;
        public string RecordStatus
        {
            get { return _recordStatus; }
            set { _recordStatus = value; OnPropertyChanged("RecordStatus"); }
        }

    }

    public class PayrollCollection : ObservableCollection<Payroll> { }

}
