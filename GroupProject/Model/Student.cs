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
            int Credit_Module4 = 1;
            int Credit_Module5 = 3;
            int Credit_Module6 = 2;
            int Credit_Module7 = 2;
            int Credit_Module8 = 3;

            double Module1_Grade;
            double Module2_Grade;
            double Module3_Grade;
            double Module4_Grade;
            double Module5_Grade;
            double Module6_Grade;
            double Module7_Grade;
            double Module8_Grade;

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

            if (Module4 > 75)
            {
                Module4_Grade = 4;
            }
            else if (Module4 > 55)
            {
                Module4_Grade = 3;
            }
            else if (Module4 > 45)
            {
                Module4_Grade = 2;
            }
            else
            {
                Module4_Grade = 0;
            }

            if (Module5 > 75)
            {
                Module5_Grade = 4;
            }
            else if (Module5 > 55)
            {
                Module5_Grade = 3;
            }
            else if (Module5 > 45)
            {
                Module5_Grade = 2;
            }
            else
            {
                Module5_Grade = 0;
            }

            if (Module6 > 75)
            {
                Module6_Grade = 4;
            }
            else if (Module6 > 55)
            {
                Module6_Grade = 3;
            }
            else if (Module6 > 45)
            {
                Module6_Grade = 2;
            }
            else
            {
                Module6_Grade = 0;
            }

            if (Module7 > 75)
            {
                Module7_Grade = 4;
            }
            else if (Module7 > 55)
            {
                Module7_Grade = 3;
            }
            else if (Module7 > 45)
            {
                Module7_Grade = 2;
            }
            else
            {
                Module7_Grade = 0;
            }

            if (Module8 > 75)
            {
                Module8_Grade = 4;
            }
            else if (Module8 > 55)
            {
                Module8_Grade = 3;
            }
            else if (Module8 > 45)
            {
                Module8_Grade = 2;
            }
            else
            {
                Module8_Grade = 0;
            }

            totalPoints =  Module1_Grade * Credit_Module1 + Module1_Grade * Credit_Module2 + Module3_Grade * Credit_Module3 + Module4_Grade * Credit_Module4 + Module5_Grade * Credit_Module5 + Module6_Grade * Credit_Module6 + Module7_Grade * Credit_Module7 + Module8_Grade * Credit_Module8;
            totalCredits = Credit_Module1 + Credit_Module2 + Credit_Module3 + Credit_Module4 + Credit_Module5 + Credit_Module6 + Credit_Module7 + Credit_Module8;

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
