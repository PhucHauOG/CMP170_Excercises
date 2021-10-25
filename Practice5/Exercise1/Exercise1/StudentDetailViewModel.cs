using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise1.SearchStudentViewModel;

namespace Exercise1
{
    public class StudentDetailViewModel : BaseViewModel, ICloseable
    {
        private int studentId;
        private string firstname;
        private string lastname;
        private string gender;
        private bool ismale;
        private string classdetail;
        private string email;

        public int StudentIdDetail
        {
            get => studentId; set
            {
                studentId = value;
                OnPropertyChanged(nameof(StudentIdDetail));
            }
        }

        public String FirstNameDetail
        {
            get => firstname;
            set
            {
                firstname = value;
                OnPropertyChanged(nameof(FirstNameDetail));
            }
        }
        public String LastNameDetail
        {
            get => lastname;
            set
            {
                lastname = value;
                OnPropertyChanged(nameof(LastNameDetail));
            }
        }
        public String GenderDetail { get => gender; set => gender = value; }
        public String ClassDetail { get => classdetail ; set => classdetail = value; }
        public String EmailDetail { get => email; set => email = value; }
        public Boolean IsMale
        {
            get => ismale;
            set
            {
                ismale = value;
                OnPropertyChanged(nameof(IsMale));
            }
        }

        public ConditionalCommand SaveCommand { get; }
        public ConditionalCommand CancelCommand { get; }

        public Boolean IsFeMale
        {
            get => !ismale;
            set
            {
                ismale = !value;
                OnPropertyChanged(nameof(IsFeMale));
            }
        }

        private readonly IStudentServive m_studentService;
        public StudentDetailViewModel(IStudentServive studentService, int studentId)
        {
            m_studentService = studentService;

            var student = m_studentService.LoadStudentById(studentId);
            StudentIdDetail = student.StudentId;
            FirstNameDetail = student.FirstName;
            LastNameDetail = student.LastName;
            GenderDetail = student.Gender;
            ClassDetail = student.Class;
            EmailDetail = student.Email;

            SaveCommand = new ConditionalCommand(x => DoSave());
            CancelCommand = new ConditionalCommand(x => DoCancel());
        }

        public Student m_student;
        private void DoSave()
        {
            m_student.StudentId = StudentIdDetail;
            m_student.FirstName = FirstNameDetail;
            m_student.LastName = LastNameDetail;
            m_student.Email = EmailDetail;
            m_student.Gender = GenderDetail;
            m_student.Class = ClassDetail;
            m_studentService.UpdateOrCreateStudent(m_student); ;
        }
        public event EventHandler CloseRequest;
        protected void DoCancel()
        {
            var handler = CloseRequest;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
