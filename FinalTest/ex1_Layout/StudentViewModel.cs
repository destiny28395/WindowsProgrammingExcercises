﻿using ex1_Layout.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ex1_Layout
{
    class StudentViewModel : BaseModel, INotifyPropertyChanged, IDataErrorInfo
    {

        private string _SID;
        private string _First_Name;
        private string _Last_Name;
        private string _Add;
        private string _Email;
        private DateTime _Birthdate=DateTime.Today;
        private List<string> _ListClass = new List<string> { "18DTHQA1", "18DTHQA2", "18DTHQA3"};
        private string selectClass;

        public StudentViewModel()
        {
            SaveCommand = new RelayCommand(o => Save(), o => !string.IsNullOrEmpty(_SID) && !string.IsNullOrEmpty(_First_Name) && !string.IsNullOrEmpty(_Last_Name));
        }
        public string lblSID
        {
            get
            {
                return _SID;
            }
            set
            {
                _SID = value;
                OnPropertyChanged(nameof(lblSID));
            }
        }
        public string lblFirst_Name
        {
            get
            {
                return _First_Name;
            }
            set
            {
                _First_Name = value;
                OnPropertyChanged(nameof(lblFirst_Name));
            }
        }
        public string lblLast_Name
        {
            get
            {
                return _Last_Name;
            }
            set
            {
                _Last_Name = value;
                OnPropertyChanged(nameof(lblLast_Name));
            }
        }
        public string lblAdd
        {
            get
            {
                return _Add;
            }
            set
            {
                _Add = value;
                OnPropertyChanged(nameof(lblAdd));
            }
        }
        public string lblEmail
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
                OnPropertyChanged(nameof(lblEmail));
            }
        }
        public DateTime lblBirthdate
        {
            get
            {
                return _Birthdate;
            }
            set
            {
                _Birthdate = value;
                OnPropertyChanged(nameof(lblBirthdate));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #region validation (IDataErrorInfo)

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (nameof(lblSID) == columnName)
                {
                    if (string.IsNullOrEmpty(lblSID))
                    {
                        result = "Name is mandatory";
                    }
                }
                else if(nameof(lblFirst_Name) == columnName)
                {
                    if (string.IsNullOrEmpty(_First_Name))
                    {
                        result = "Name is mandatory";
                    }
                }
                else if(nameof(lblLast_Name) == columnName)
                {
                    if (string.IsNullOrEmpty(_Last_Name))
                    {
                        result = "Name is mandatory";
                    }
                }
                return result;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region Command

        public ICommand SaveCommand { get; set; }

        public string SelectClass
        {
            get
            {
                return selectClass;
            }

            set
            {
                selectClass = value;
            }
        }

        public List<string> ListClass
        {
            get
            {
                return _ListClass;
            }

            set
            {
                _ListClass = value;
            }
        }

        public void Save()
        {

        }

        #endregion
    }
}

