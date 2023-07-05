namespace ChallangeApp.Tests
{
    public class ReferencesTypeTest
    {
        [Test]
        public void WhenEmployeeAreNotTheSame_SchouldReturnCorect()
        {
            var Emp1 = new Employee("Adam", "Nowak");
            var Emp2 = new Employee("Adam", "Nowak");

            Assert.AreNotEqual(Emp1, Emp2);
        }
        [Test]
        public void WhenEmployeeNmaeAreTheSame_SchouldReturnCorect()
        {
            var Emp1 = new Employee("Adam", "Nowak");
            var Emp2 = new Employee("Adam", "Nowak" );

            Assert.AreSame(Emp1.Name, Emp2.Name);
        }
        private Employee AddEmployee(string name,string lastname)
        {
            return new Employee(name, lastname);
        }
    }
    
}
