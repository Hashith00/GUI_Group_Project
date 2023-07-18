using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIProject.Model;


namespace GUIProject.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Module1 { get; set; }
        public double Module2 { get; set; }
        public double Module3 { get; set; }
        public double Module4 { get; set; }
        public double Module5 { get; set; }
        public double Module6 { get; set; }
        public double Module7 { get; set; }
        public double Module8 { get; set; }

        private double _GPA;
        public double GPA { get => CalculateGPA(); set => _GPA = 0.0; }

        public double CalculateGPA()
        {
            double totalPoints;
            double totalCredits;

            int Credit_Module1 = 3;
            int Credit_Module2 = 2;
            int Credit_Module3 = 1;

            double Module1_Grade;
            double Module2_Grade;
            double Module3_Grade;

            double gpa;
            /////////////////////////////////////////////////
            if (Module1 > 75)
            {
                Module1_Grade = 4;
            }
            else if (Module1 > 65)
            {
                Module1_Grade = 3;
            }
            else if (Module1 > 45)
            {
                Module1_Grade = 2;
            }

            else
            {
                Module1_Grade = 0;
            }
            ////////////////////////////////////////////////////////////////////
            if (Module2 > 75)
            {
                Module1_Grade = 4;
            }
            else if (Module2 > 55)
            {
                Module1_Grade = 3;
            }
            else if (Module2 > 45)
            {
                Module1_Grade = 2;
            }
            else
            {
                Module1_Grade = 0;
            }
            /////////////////////////////////////////////////////////////////
            if (Module3 > 75)
            {
                Module3_Grade = 4;
            }
            else if (Module3 > 55)
            {
                Module3_Grade = 3;
            }
            else if (Module3 > 45)
            {
                Module3_Grade = 2;
            }
            else
            {
                Module3_Grade = 0;
            }

            totalPoints = Module3_Grade * Credit_Module3 + Module1_Grade * Credit_Module2 + Module1_Grade * Credit_Module1;
            totalCredits = Credit_Module1 + Credit_Module2 + Credit_Module3;

            if (totalCredits == 0 || totalPoints == 0)
            {
                gpa = 0;
            }
            else
            {
                gpa = totalPoints / totalCredits;
            }

            return gpa;
        }
    }
}
