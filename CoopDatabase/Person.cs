using System;

namespace ModelsLibrary.CoopDatabase
{
    public class Person : AbstractModel
    {
        private int _age;
        private DateTime _birthDate;
        private string _civilStatus;
        private string _firstName;
        private string _lastName;

        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age");}
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        public string CivilStatus
        {
            get { return _civilStatus; }
            set { _civilStatus = value; OnPropertyChanged("CivilStatus"); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }
    }
}
