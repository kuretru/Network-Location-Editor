using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkLocationEditor
{
    public class NTProfiles
    {
        private Guid _profileGuid;
        private string _profileName;
        private string _description;
        private int _category;
        private int _categoryType;
        private DateTime _createdDate;
        private DateTime _lastConnectedDate;
        private bool _managed;
        private string _nameType;
        public Guid ProfileGuid
        {
            get
            {
                return _profileGuid;
            }

            set
            {
                _profileGuid = value;
            }
        }
        public string ProfileName
        {
            get
            {
                return _profileName;
            }

            set
            {
                _profileName = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public int Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }
        public int CategoryType
        {
            get
            {
                return _categoryType;
            }

            set
            {
                _categoryType = value;
            }
        }
        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }

            set
            {
                _createdDate = value;
            }
        }
        public DateTime LastConnectedDate
        {
            get
            {
                return _lastConnectedDate;
            }

            set
            {
                _lastConnectedDate = value;
            }
        }
        public bool Managed
        {
            get
            {
                return _managed;
            }

            set
            {
                _managed = value;
            }
        }
        public string NameType
        {
            get
            {
                return _nameType;
            }

            set
            {
                _nameType = value;
            }
        }
    }
}
