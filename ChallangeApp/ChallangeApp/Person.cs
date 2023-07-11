namespace ChallangeApp
{
    public abstract class Person
    {
        public Person(string name, string lastName,char sex,int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }
    }
}
