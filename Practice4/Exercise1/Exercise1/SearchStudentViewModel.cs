using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exercise1
{
    public class Student 
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public Decimal Gpa { get; set; }
    }

    class SearchStudentViewModel : BaseViewModel
    {
        private string m_searchKeyword;
        public string SearchKeyword {
            get => m_searchKeyword;
            set
            {
                m_searchKeyword = value;
                OnPropertyChanged(nameof(SearchKeyword));
            }
        }

        private string m_selectedClass;
        public string SelectedClass
        {
            get => m_selectedClass;
            set
            {
                m_selectedClass = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }

        private Student m_selectedStudent;
        public Student SelectedStudent
        {
            get => m_selectedStudent;
            set
            {
                m_selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }
        public ObservableCollection<Student> Students {get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }

        private IStudentServive m_studentSrv;
        public SearchStudentViewModel() 
        {
            var data = File.ReadAllText("Student_Data.json");
            var students = JsonConvert.DeserializeObject<List<Student>>(data);
            Students = new ObservableCollection<Student>(students);
            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
        }

        public void DoOpenDetail() {
            var studentDetailViewModel = new StudentDetailViewModel(SelectedStudent);
            Student_Detail studentDetail = new Student_Detail();
            studentDetail.DataContext = studentDetailViewModel;
            studentDetail.ShowDialog();
            m_studentSrv = new StudentServiceWithFile();
            Students = new ObservableCollection<Student>(m_studentSrv.SearchStudent(string.Empty, string.Empty));

            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
            SearchCommand = new ConditionalCommand(x => DoSearch());
            ResetCommand = new ConditionalCommand(x => DoReset());
        }
        public void DoReset()
        {
            SearchKeyword = null;
            SelectedClass = null;
        }

        private void DoSearch()
        {
            Student.Clear();
            var result = m_studentSrv.SearchStudent(SearchKeyword, SelectedClass);
            foreach (var s in result)
            {
                Students.Add();
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
