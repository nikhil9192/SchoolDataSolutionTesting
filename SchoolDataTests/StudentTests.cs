using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SchoolDataSolution;


namespace SchoolDataTests
{
    // StudentTests.cs


    [TestFixture]

    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Nikhil Singh";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Nikhil Singh", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "Gorkhpur Uttarpradesh";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("Gorkhpur Uttarpradesh", studentAddress);
        }
    }
}

