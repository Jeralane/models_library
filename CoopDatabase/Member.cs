using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLibrary.CoopDatabase
{
    public class Member : AbstractModel
    {
        private string _memberCode;
        private string _memberName;
        private int _personId;

        public string MemberCode
        {
            get { return _memberCode; }
            set { _memberCode = value; OnPropertyChanged("MemberCode"); }
        }

        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; OnPropertyChanged("MemberName"); }
        }

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; OnPropertyChanged("PersonId"); }
        }
    }
}
