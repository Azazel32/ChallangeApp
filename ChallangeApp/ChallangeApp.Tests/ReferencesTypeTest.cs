namespace ChallangeApp.Tests
{
    public class ReferencesTypeTest
    {
        [Test]
        public void WhenEmployeeAreNotTheSame_SchouldReturnCorect()
        {
            var Emp1 = AddEmployee("Adam", "Nowak", "20");
            var Emp2 = AddEmployee("Adam", "Nowak", "20");

            Assert.AreNotEqual(Emp1, Emp2);
        }
        [Test]
        public void WhenEmployeeNmaeAreTheSame_SchouldReturnCorect()
        {
            var Emp1 = AddEmployee("Adam", "Nowak", "20");
            var Emp2 = AddEmployee("Adam", "Nowak", "20");

            Assert.AreSame(Emp1.Name, Emp2.Name);
        }
        private Employee AddEmployee(string name,string lastname,string age)
        {
            return new Employee(name, lastname, age);
        }
    }
    
}
