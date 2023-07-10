namespace ChallangeApp
{
    public abstract class Person
    {
        public Person(string name, string last_name,char sex,int age)
        {
            this.Name = name;
            this.Last_name = last_name;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Last_name { get; private set; }
        public char Sex { get; private set; }
        public int Age { get; private set; }
    }
}
