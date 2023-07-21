using FluentAssertions;
using GUIProject.Model;
using Xunit;

namespace GUIProject.Tests
{
    public class StudentTests
    {
        [Fact]
        public void CalculatedGPAShouldbeCorrect()
        {
            
            var student = new Student
            {
                Module1 = 80,
                Module2 = 60,
                Module3 = 50,
                Module4 = 50,
                Module5 = 50,
                Module6 = 50,
                Module7 = 50,
                Module8 = 50
            };

          
            var gpa = student.CalculateGPA();

           
            gpa.Should().Be(3.0);
        }

        [Fact]
        public void ZeroCreditsShouldReturnZeroGPA()
        {
            
            var student = new Student
            {
                Module1 = 0,
                Module2 = 0,
                Module3 = 0, 
                Module4 = 0,
                Module5 = 0,
                Module6 = 0,
                Module7 = 0,
                Module8 = 0

            };
            student.Module1 = 0;
            student.Module2 = 0;
            student.Module3 = 0;
            student.Module4 = 0;
            student.Module5 = 0;
            student.Module6 = 0;
            student.Module7 = 0;
            student.Module8 = 0;


            var gpa = student.CalculateGPA();

           
            gpa.Should().Be(0.0);
        }

        [Fact]
        public void CalculateGPAWithZeroPointsShouldReturnZero()
        {
            
            var student = new Student();

          
            var gpa = student.CalculateGPA();

           
            gpa.Should().Be(0.0);
        }
    }
}
