namespace ChallangeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();

        public Employee(string name, string last_name) 
        {
            this.Name = name;
            this.LastName = last_name;
        }
        public string Name { get; private set; }
        public string LastName { get; private set;}
        public void AddGrade(float grade)
        {
            if (grade >=0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
            
        }
        public void AddGrade(string grade) 
        {
            if (float.TryParse(grade,out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
           this.AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public Statistics GetStatistics()
        {
            var statistics= new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            
            foreach (var grade in this.grades) 
            {
                statistics.Average += grade;
                statistics.Max=Math.Max(statistics.Max, grade);
                statistics.Min=Math.Min(statistics.Min, grade);
            }
            statistics.Average /= grades.Count;
            return statistics;
        }


        

    }
}
