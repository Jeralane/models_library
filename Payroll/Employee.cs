using System;

namespace ModelsLibrary.Payroll
{
    public partial class Employee : AbstractModel
    {
        private int _employeeStatus;
        public int EmployeeStatus
        {
            get { return _employeeStatus; }
            set { _employeeStatus = value; OnPropertyChanged("EmployeeStatus"); }
        }

        private string _issuedId;
        public string IssuedId
        {
            get { return _issuedId; }
            set { _issuedId = value; OnPropertyChanged("IssuedId"); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); }
        }

        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; OnPropertyChanged("MiddleName"); }
        }

        private DateTime _dateApplied;
        public DateTime DateApplied
        {
            get { return _dateApplied; }
            set { _dateApplied = value; OnPropertyChanged("DateApplied"); }
        }

        private DateTime _dateHired;
        public DateTime DateHired
        {
            get { return _dateHired; }
            set { _dateHired = value; OnPropertyChanged("DateHired"); }
        }

        private DateTime _dateEnd;
        public DateTime DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; OnPropertyChanged("DateEnd"); }
        }

        private string _badgeNumber;
        public string BadgeNumber
        {
            get { return _badgeNumber; }
            set { _badgeNumber = value; OnPropertyChanged("BadgeNumber"); }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; OnPropertyChanged("BirthDate"); }
        }

        private string _birthPlace;
        public string BirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; OnPropertyChanged("BirthPlace"); }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged("Gender"); }
        }

        private string _nationality;
        public string Nationality
        {
            get { return _nationality; }
            set { _nationality = value; OnPropertyChanged("Nationality"); }
        }

        private string _religion;
        public string Religion
        {
            get { return _religion; }
            set { _religion = value; OnPropertyChanged("Religion"); }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age"); }
        }

        private string _civilStatus;
        public string CivilStatus
        {
            get { return _civilStatus; }
            set { _civilStatus = value; OnPropertyChanged("CivilStatus"); }
        }

        private string _landLineNumber;
        public string LandLineNumber
        {
            get { return _landLineNumber; }
            set { _landLineNumber = value; OnPropertyChanged("LandLineNumber"); }
        }

        private string _cellPhoneNumber;
        public string CellPhoneNumber
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; OnPropertyChanged("CellPhoneNumber"); }
        }

        private string _emailAddress;
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; OnPropertyChanged("EmailAddress"); }
        }

        private string _currentAddress;
        public string CurrentAddress
        {
            get { return _currentAddress; }
            set { _currentAddress = value; OnPropertyChanged("CurrentAddress"); }
        }

        private string _permanentlAddress;
        public string PermanentlAddress
        {
            get { return _permanentlAddress; }
            set { _permanentlAddress = value; OnPropertyChanged("PermanentlAddress"); }
        }

        private string _elementarySchoolName;
        public string ElementarySchoolName
        {
            get { return _elementarySchoolName; }
            set { _elementarySchoolName = value; OnPropertyChanged("ElementarySchoolName"); }
        }

        private string _elementaryYearAttended;
        public string ElementaryYearAttended
        {
            get { return _elementaryYearAttended; }
            set { _elementaryYearAttended = value; OnPropertyChanged("ElementaryYearAttended"); }
        }

        private string _elementaryMerits;
        public string ElementaryMerits
        {
            get { return _elementaryMerits; }
            set { _elementaryMerits = value; OnPropertyChanged("ElementaryMerits"); }
        }

        private string _highSchoolName;
        public string HighSchoolName
        {
            get { return _highSchoolName; }
            set { _highSchoolName = value; OnPropertyChanged("HighSchoolName"); }
        }

        private string _highSchoolYearAttended;
        public string HighSchoolYearAttended
        {
            get { return _highSchoolYearAttended; }
            set { _highSchoolYearAttended = value; OnPropertyChanged("HighSchoolYearAttended"); }
        }

        private string _highSchoolMerits;
        public string HighSchoolMerits
        {
            get { return _highSchoolMerits; }
            set { _highSchoolMerits = value; OnPropertyChanged("HighSchoolMerits"); }
        }

        private string _collegeSchoolName;
        public string CollegeSchoolName
        {
            get { return _collegeSchoolName; }
            set { _collegeSchoolName = value; OnPropertyChanged("CollegeSchoolName"); }
        }

        private string _collegeYearAttended;
        public string CollegeYearAttended
        {
            get { return _collegeYearAttended; }
            set { _collegeYearAttended = value; OnPropertyChanged("CollegeYearAttended"); }
        }

        private string _collegeMerits;
        public string CollegeMerits
        {
            get { return _collegeMerits; }
            set { _collegeMerits = value; OnPropertyChanged("CollegeMerits"); }
        }

        private string _collegeCourse;
        public string CollegeCourse
        {
            get { return _collegeCourse; }
            set { _collegeCourse = value; OnPropertyChanged("CollegeCourse"); }
        }

        private string _higherStudiesSchoolName;
        public string HigherStudiesSchoolName
        {
            get { return _higherStudiesSchoolName; }
            set { _higherStudiesSchoolName = value; OnPropertyChanged("HigherStudiesSchoolName"); }
        }

        private string _higherStudiesYearAttended;
        public string HigherStudiesYearAttended
        {
            get { return _higherStudiesYearAttended; }
            set { _higherStudiesYearAttended = value; OnPropertyChanged("HigherStudiesYearAttended"); }
        }

        private string _higherStudiesMerits;
        public string HigherStudiesMerits
        {
            get { return _higherStudiesMerits; }
            set { _higherStudiesMerits = value; OnPropertyChanged("HigherStudiesMerits"); }
        }

        private string _higherStudiesCourse;
        public string HigherStudiesCourse
        {
            get { return _higherStudiesCourse; }
            set { _higherStudiesCourse = value; OnPropertyChanged("HigherStudiesCourse"); }
        }

        private string _vocationalSchoolName;
        public string VocationalSchoolName
        {
            get { return _vocationalSchoolName; }
            set { _vocationalSchoolName = value; OnPropertyChanged("VocationalSchoolName"); }
        }

        private string _vocationalYearAttended;
        public string VocationalYearAttended
        {
            get { return _vocationalYearAttended; }
            set { _vocationalYearAttended = value; OnPropertyChanged("VocationalYearAttended"); }
        }

        private string _vocationalMerits;
        public string VocationalMerits
        {
            get { return _vocationalMerits; }
            set { _vocationalMerits = value; OnPropertyChanged("VocationalMerits"); }
        }

        private string _vocationalCourse;
        public string VocationalCourse
        {
            get { return _vocationalCourse; }
            set { _vocationalCourse = value; OnPropertyChanged("VocationalCourse"); }
        }

        private string _tINNumber;
        public string TINNumber
        {
            get { return _tINNumber; }
            set { _tINNumber = value; OnPropertyChanged("TINNumber"); }
        }

        private int _taxGroupId;
        public int TaxGroupId
        {
            get { return _taxGroupId; }
            set { _taxGroupId = value; OnPropertyChanged("TaxGroupId"); }
        }

        private string _sSSNumber;
        public string SSSNumber
        {
            get { return _sSSNumber; }
            set { _sSSNumber = value; OnPropertyChanged("SSSNumber"); }
        }

        private string _pagibigNumber;
        public string PagibigNumber
        {
            get { return _pagibigNumber; }
            set { _pagibigNumber = value; OnPropertyChanged("PagibigNumber"); }
        }

        private string _philhealthNumber;
        public string PhilhealthNumber
        {
            get { return _philhealthNumber; }
            set { _philhealthNumber = value; OnPropertyChanged("PhilhealthNumber"); }
        }

        private string _companyName1;
        public string CompanyName1
        {
            get { return _companyName1; }
            set { _companyName1 = value; OnPropertyChanged("CompanyName1"); }
        }

        private DateTime _dateEmployed1;
        public DateTime DateEmployed1
        {
            get { return _dateEmployed1; }
            set { _dateEmployed1 = value; OnPropertyChanged("DateEmployed1"); }
        }

        private string _location1;
        public string Location1
        {
            get { return _location1; }
            set { _location1 = value; OnPropertyChanged("Location1"); }
        }

        private string _position1;
        public string Position1
        {
            get { return _position1; }
            set { _position1 = value; OnPropertyChanged("Position1"); }
        }

        private string _reasonLeaving1;
        public string ReasonLeaving1
        {
            get { return _reasonLeaving1; }
            set { _reasonLeaving1 = value; OnPropertyChanged("ReasonLeaving1"); }
        }

        private string _companyName2;
        public string CompanyName2
        {
            get { return _companyName2; }
            set { _companyName2 = value; OnPropertyChanged("CompanyName2"); }
        }

        private DateTime _dateEmployed2;
        public DateTime DateEmployed2
        {
            get { return _dateEmployed2; }
            set { _dateEmployed2 = value; OnPropertyChanged("DateEmployed2"); }
        }

        private string _location2;
        public string Location2
        {
            get { return _location2; }
            set { _location2 = value; OnPropertyChanged("Location2"); }
        }

        private string _position2;
        public string Position2
        {
            get { return _position2; }
            set { _position2 = value; OnPropertyChanged("Position2"); }
        }

        private string _reasonLeaving2;
        public string ReasonLeaving2
        {
            get { return _reasonLeaving2; }
            set { _reasonLeaving2 = value; OnPropertyChanged("ReasonLeaving2"); }
        }

        private string _illnesAllergysSpecify;
        public string IllnesAllergysSpecify
        {
            get { return _illnesAllergysSpecify; }
            set { _illnesAllergysSpecify = value; OnPropertyChanged("IllnesAllergysSpecify"); }
        }

        private string _emergencyNotify;
        public string EmergencyNotify
        {
            get { return _emergencyNotify; }
            set { _emergencyNotify = value; OnPropertyChanged("EmergencyNotify"); }
        }

        private string _emergencyNotifyRelation;
        public string EmergencyNotifyRelation
        {
            get { return _emergencyNotifyRelation; }
            set { _emergencyNotifyRelation = value; OnPropertyChanged("EmergencyNotifyRelation"); }
        }

        private string _emergencyNotifyAddress;
        public string EmergencyNotifyAddress
        {
            get { return _emergencyNotifyAddress; }
            set { _emergencyNotifyAddress = value; OnPropertyChanged("EmergencyNotifyAddress"); }
        }

        private string _emergencyNotifyTelephone;
        public string EmergencyNotifyTelephone
        {
            get { return _emergencyNotifyTelephone; }
            set { _emergencyNotifyTelephone = value; OnPropertyChanged("EmergencyNotifyTelephone"); }
        }

        private string _criminalCaseSpecify;
        public string CriminalCaseSpecify
        {
            get { return _criminalCaseSpecify; }
            set { _criminalCaseSpecify = value; OnPropertyChanged("CriminalCaseSpecify"); }
        }

        private DateTime _criminalCaseDate;
        public DateTime CriminalCaseDate
        {
            get { return _criminalCaseDate; }
            set { _criminalCaseDate = value; OnPropertyChanged("CriminalCaseDate"); }
        }

        private string _convictedSpecify;
        public string ConvictedSpecify
        {
            get { return _convictedSpecify; }
            set { _convictedSpecify = value; OnPropertyChanged("ConvictedSpecify"); }
        }

        private DateTime _convictedDate;
        public DateTime ConvictedDate
        {
            get { return _convictedDate; }
            set { _convictedDate = value; OnPropertyChanged("ConvictedDate"); }
        }

        private string _referenceName1;
        public string ReferenceName1
        {
            get { return _referenceName1; }
            set { _referenceName1 = value; OnPropertyChanged("ReferenceName1"); }
        }

        private string _referenceAddress1;
        public string ReferenceAddress1
        {
            get { return _referenceAddress1; }
            set { _referenceAddress1 = value; OnPropertyChanged("ReferenceAddress1"); }
        }

        private string _referenceTelephone1;
        public string ReferenceTelephone1
        {
            get { return _referenceTelephone1; }
            set { _referenceTelephone1 = value; OnPropertyChanged("ReferenceTelephone1"); }
        }

        private string _referenceName2;
        public string ReferenceName2
        {
            get { return _referenceName2; }
            set { _referenceName2 = value; OnPropertyChanged("ReferenceName2"); }
        }

        private string _referenceAddress2;
        public string ReferenceAddress2
        {
            get { return _referenceAddress2; }
            set { _referenceAddress2 = value; OnPropertyChanged("ReferenceAddress2"); }
        }

        private string _referenceTelephone2;
        public string ReferenceTelephone2
        {
            get { return _referenceTelephone2; }
            set { _referenceTelephone2 = value; OnPropertyChanged("ReferenceTelephone2"); }
        }

        private string _license;
        public string License
        {
            get { return _license; }
            set { _license = value; OnPropertyChanged("License"); }
        }

        private DateTime _licenseDate;
        public DateTime LicenseDate
        {
            get { return _licenseDate; }
            set { _licenseDate = value; OnPropertyChanged("LicenseDate"); }
        }

        private DateTime _licenseDueDate;
        public DateTime LicenseDueDate
        {
            get { return _licenseDueDate; }
            set { _licenseDueDate = value; OnPropertyChanged("LicenseDueDate"); }
        }

        private string _licenseActive;
        public string LicenseActive
        {
            get { return _licenseActive; }
            set { _licenseActive = value; OnPropertyChanged("LicenseActive"); }
        }

    }
}
