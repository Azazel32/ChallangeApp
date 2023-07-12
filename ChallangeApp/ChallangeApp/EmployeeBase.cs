namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name,string lastname,int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;

        }

        public  string Name { get; private set; }
        public  int Age { get; private set; }
        public  string LastName { get; }
        

        public abstract void AddGrade(char grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(float grade);
        public abstract Statistics GetStatistics();
    }
}
