namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetsOnlyPositiveScore_SchouldReturnCorectSum()
        {
            var employee=new Employee("Marcin","kowalski","25");
            employee.AddScore(10);
            employee.AddScore(4);
            var result = employee.Result;
            Assert.AreEqual(14, result);
        }
        [Test]
        public void WhenEmployeeGetsDiffrentScore_SchouldReturnCorectSum()
        {
            var employee = new Employee("Marcin", "kowalski", "25");
            employee.AddScore(10);
            employee.AddScore(-4);
            employee.AddScore(-8);
            var result = employee.Result;
            Assert.AreEqual(-2, result);
        }
        [Test]
        public void WhenEmployeeGetsOnlyNegativeScore_SchouldReturnCorectSum()
        {
            var employee = new Employee("Marcin", "kowalski", "25");
            employee.AddScore(-10);
            employee.AddScore(-4);
            var result = employee.Result;
            Assert.AreEqual(-14, result);
        }
    }
}