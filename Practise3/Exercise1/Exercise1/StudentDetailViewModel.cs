using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise1.SearchStudentViewModel;

namespace Exercise1
{
    class StudentDetailViewModel : BaseViewModel
    {
        private int studentiddetail;
        public int StudentIdDetail 
        { 
            get => studentiddetail;
            set 
            {
                studentiddetail = value;
                OnPropertyChanged(nameof(StudentIdDetail));
            }
        }

        private string firstnamedetail;
        public string FirstNameDetail 
        {
            get => firstnamedetail;
            set
            {
                firstnamedetail = value;
                OnPropertyChanged(nameof(FirstNameDetail));
            }
        }

        private string lastnamedetail;
        public string LastNameDetail 
        { 
            get => lastnamedetail;
            set 
            {
                lastnamedetail = value;
                OnPropertyChanged(nameof(LastNameDetail));
            }
        }

        private string emaildetail;
        public string EmailDetail
        {
            get => emaildetail;
            set 
            {
                emaildetail = value;
                OnPropertyChanged(nameof(EmailDetail));
            }
        }

        private string classdetail;
        public string ClassDetail 
        {
            get => classdetail;
            set 
            {
                classdetail = value;
                OnPropertyChanged(nameof(ClassDetail));
            }
        }

        private string genderdetail;
        public string GenderDetail 
        {
            get => genderdetail;
            set
            {
                genderdetail = value;
                OnPropertyChanged(nameof(GenderDetail));
            }
        }

        private bool ismale;
        public Boolean IsMale
        {
            get => ismale;
            set
            {
                ismale = value;
                OnPropertyChanged(nameof(IsMale));
            }
        }

        public Boolean IsFemale
        {
            get => !ismale;
            set
            {
                ismale = !value;
                OnPropertyChanged(nameof(IsFemale));
            }
        }
        public StudentDetailViewModel(Student student) 
        {
            StudentIdDetail = student.StudentId;
            FirstNameDetail = student.FirstName;
            LastNameDetail = student.LastName;
            EmailDetail = student.Email;
            ClassDetail = student.Class;
            GenderDetail = student.Gender;
            IsMale = (GenderDetail == "Male");
        }
    }
}
