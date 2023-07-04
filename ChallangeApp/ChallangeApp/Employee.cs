using System.Security.Cryptography.X509Certificates;

namespace ChallangeApp
{
    public class Employee
    {
        public List<int> Score = new List<int>();

        public Employee(string name, string last_name, string age) 
        {
            this.Name = name;
            this.LastName = last_name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string LastName { get; private set;}
        public string Age { get; private set;} 
        public int Result 
        { 
            get
            {
                return this.Score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.Score.Add(score);
        }

        

    }
}
