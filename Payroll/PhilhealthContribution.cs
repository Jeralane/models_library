namespace ModelsLibrary.Payroll
{
    public partial class PhilhealthContribution : AbstractModel
    {
        private decimal _minimum;
        private decimal _maximum;
        private decimal _employeeShare;
        private decimal _employerShare;
        private decimal _total;

        public decimal Minimum
        {
            get { return _minimum; }
            set
            {
                _minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        public decimal Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                OnPropertyChanged("Maximum");
            }
        }

        public decimal EmployeeShare
        {
            get { return _employeeShare; }
            set
            {
                _employeeShare = value;
                OnPropertyChanged("EmployeeShare");
                Total = _employeeShare + _employerShare;
            }
        }

        public decimal EmployerShare
        {
            get { return _employerShare; }
            set
            {
                _employerShare = value;
                OnPropertyChanged("EmployerShare");
                Total = _employeeShare + _employerShare;
            }
        }

        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }
    }


}
