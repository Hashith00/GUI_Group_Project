using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUIProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GUIProject.ViewModel
{
    public partial class DatabaseWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public double module1;

        [ObservableProperty]
        public double module2;

        [ObservableProperty]
        public double module3;

        [ObservableProperty]
        public double module4;

        [ObservableProperty]
        public double module5;

        [ObservableProperty]
        public double module6;

        [ObservableProperty]
        public double module7;

        [ObservableProperty]
        public double module8;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        ObservableCollection<Student> students;

        [ObservableProperty]
        public Student selectedStudent = null;

        
        



        [RelayCommand]
        public void InsertStudent()
        {


            Student p = new Student()
            {
                Name = "",
                Age = 0,
                Module1 = 10,
                Module2 = 20,
                Module3 = 30,
                Module4 = 30,
                Module5 = 30,
                Module6 = 30,
                Module7 = 30,
                Module8 = 30,

            };
            selectedStudent = p;
            students.Add(p);

            using (var db = new UserDataContext())
            {
                db.Students.Add(p);
                db.SaveChanges();
            }
            LoadStudent();
        }

        [RelayCommand]
        public void UpdateStudent()
        {
            using (var db = new UserDataContext())
            {
                var existingStudent = db.Students.FirstOrDefault(p => p.Id == selectedStudent.Id);
                if (existingStudent != null)
                {
                    existingStudent.Name = selectedStudent.Name;
                    existingStudent.Age = selectedStudent.Age;
                    existingStudent.Module1 = selectedStudent.Module1;
                    existingStudent.Module2 = selectedStudent.Module2;
                    existingStudent.Module3 = selectedStudent.Module3;
                    existingStudent.Module4 = selectedStudent.Module4;
                    existingStudent.Module5 = selectedStudent.Module5;
                    existingStudent.Module6 = selectedStudent.Module6;
                    existingStudent.Module7 = selectedStudent.Module7;
                    existingStudent.Module8 = selectedStudent.Module8;

                    db.SaveChanges();
                }
            }
            LoadStudent();
        }


        [RelayCommand]
        public void DeleteStudent()
        {
            using (var db = new UserDataContext())
            {
                var existingStudent = db.Students.FirstOrDefault(p => p.Id == selectedStudent.Id);
                if (existingStudent != null)
                {
                    db.Students.Remove(existingStudent);
                    db.SaveChanges();
                    students.Remove(selectedStudent);
                }
            }
            LoadStudent();
        }

        [RelayCommand]
        public void LoadStudent()
        {
            using (var db = new UserDataContext())
            {
                var list = db.Students.OrderBy(p => p.Id).ToList();
                students.Clear();
                foreach (var user in list)
                {
                    students.Add(user);
                }

            }

        }

        public DatabaseWindowVM()
        {
            students = new ObservableCollection<Student>();
            LoadStudent();
            


        }
    }
}
