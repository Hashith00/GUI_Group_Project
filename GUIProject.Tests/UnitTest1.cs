using FluentAssertions;
using GUIProject.Model;
using Xunit;

namespace GUIProject.Tests
{
    public class StudentTests
    {
        [Fact]
        public void CalculateGPAShouldReturnCorrectValue()
        {
            
            var student = new Student
            {
                Module1 = 80,
                Module2 = 60,
                Module3 = 50
            };

          
            var gpa = student.CalculateGPA();

           
            gpa.Should().Be(3.0);
        }

        [Fact]
        public void CalculateGPAWithZeroCreditsShouldReturnZero()
        {
            
            var student = new Student
            {
                Module1 = 0,
                Module2 = 0,
                Module3 = 0
            };
            student.Module1 = 0;
            student.Module2 = 0;
            student.Module3 = 0;

            
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
