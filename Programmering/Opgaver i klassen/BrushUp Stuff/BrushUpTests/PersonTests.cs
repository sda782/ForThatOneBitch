using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace BrushUp.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void NameTest()
        {
            Student student = new Student();
            student.Name = "Oliver";

            Assert.AreEqual(student.Name, "Oliver");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                student.Name = "K";
            });

        }

        [TestMethod]
        public void SemesterTest()
        {
            Student student = new Student();

            student.Semester = 4;

            Assert.AreEqual(student.Semester, 4);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                student.Semester = 9;
            });
        }

        [TestMethod]
        public void SalaryTest()
        {
            Teacher teacher = new Teacher();

            teacher.Salary = 5000;

            Assert.AreEqual(teacher.Salary, 5000);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                teacher.Salary = -1;
            });
        }

        [TestMethod]
        public void AddressTest()
        {
            Student student = new Student();

            student.Address = "Roskildevej 56";

            Assert.AreEqual(student.Address, "Roskildevej 56");

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                student.Address = null;
            });
        }

        [TestMethod]
        public void ToStringTest()
        {
            Teacher teacher = new Teacher();

            teacher.Name = "karl";
            teacher.Address = "Testvej 21";
            teacher._Gender = Person.GenderType.Male;

            string expected = $"Name: {teacher.Name}, Address: {teacher.Address}, Gender: {teacher._Gender}";

            Assert.AreEqual(teacher.ToString(), expected);
        }
    }
}