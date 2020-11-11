using Common.Model;
using Common.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpf_practice.Service;

namespace ex1_Layout
{
    class WindowModel:BaseModel
    {
        private List<string> _ListClass = new List<string> { "18DTHQA1", "18DTHQA2", "18DTHQA3" };
        private string _selectClass;
        private string _searchText;

        public WindowModel()
        {
            StudentService = new StudentService();

            SearchCommand = new RelayCommand(Search);
            ResetCommand = new RelayCommand(o=>Reset());
            NewCommand = new RelayCommand(New);

            StudentList = new ObservableCollection<Student>(StudentService.SearchStudent(new StudentSearchCriteria()));
            ClassList = new ObservableCollection<string>(StudentService.GetAllClasses());
            
        }
        public IStudentService StudentService { get; set; }
        public ObservableCollection<Student> StudentList { get; set; }
        public ObservableCollection<string> ClassList { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand NewCommand { get; set; }
        public ICommand ExitCommand { get; set; }
  

        public List<string> ListClass
        {
            get
            {
                return _ListClass;
            }
            set
            {
                _ListClass = value;
                OnPropertyChanged(nameof(SearchCommand));
            }
        }

        public string SelectClass
        {
            get
            {
                return _selectClass;
            }

            set
            {
                _selectClass = value;
                OnPropertyChanged(nameof(SelectClass));
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }
        public void Search(object o)
        {
            StudentList.Clear();
            var result = new StudentSearchCriteria 
            { SearchText = SearchText, ClassName = _selectClass };
            StudentService.SearchStudent(result).ForEach(s => StudentList.Add(s));
        }
        public void Reset()
        {
            SearchText = string.Empty;
            SelectClass = null;
            StudentList.Clear();
            StudentService.SearchStudent(new StudentSearchCriteria()).ForEach(s => StudentList.Add(s));
        }
        public void New(object o)
        {
            Window open = new NewStudent();
            open.ShowDialog();
        }
    }
}
