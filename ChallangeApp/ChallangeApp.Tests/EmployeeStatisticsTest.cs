namespace ChallangeApp.Tests
{
    internal class EmployeeStatisticsTest
    {
        [Test]
        public void WhatExpectedMaxGradeIsMaxGrade()
        {
            var Employee = new Employee("Adam","Nowak");
            Employee.AddGrade(8);
            Employee.AddGrade(9);
            Employee.AddGrade(10);

            var statistics= Employee.GetStatistics();

            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhatExpectedMinGradeIsMinGrade()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(8);
            Employee.AddGrade(9);
            Employee.AddGrade(10);

            var statistics = Employee.GetStatistics();

            Assert.AreEqual(8, statistics.Min);
        }
    }
}
