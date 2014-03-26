using System;
using System.Collections.ObjectModel;

namespace ModelsLibrary.Payroll
{
	public partial class EmployeeStatus : AbstractModel
	{
		private string _description;
		public  string Description
		{
			get { return _description; }
			set { _description = value; OnPropertyChanged("Description"); }
		}

	}

	public class EmployeeStatusCollection : ObservableCollection<EmployeeStatus>{ }

}
