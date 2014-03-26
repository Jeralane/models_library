namespace ModelsLibrary.Payroll
{
    public partial class TaxGroup : AbstractModel
    {
        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
    }
}
