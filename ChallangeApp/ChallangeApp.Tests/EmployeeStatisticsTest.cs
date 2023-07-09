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
        [Test]
        public void ExpextedAverageLetter_SchouldIsA()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(100);
            Employee.AddGrade(100);
            Employee.AddGrade(100);
            var statistics = Employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsB()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(60);
            Employee.AddGrade(550);
            Employee.AddGrade(80);
            var statistics = Employee.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsC()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(60.5);
            Employee.AddGrade(45);
            Employee.AddGrade(40);
            var statistics = Employee.GetStatistics();

            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsD()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(25);
            Employee.AddGrade(30);
            Employee.AddGrade(20);
            var statistics = Employee.GetStatistics();

            Assert.AreEqual('D', statistics.AverageLetter);
        }
        [Test]
        public void ExpextedAverageLetter_SchouldIsE()
        {
            var Employee = new Employee("Adam", "Nowak");
            Employee.AddGrade(15);
            Employee.AddGrade(10);
            Employee.AddGrade(10);
            var statistics = Employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}
