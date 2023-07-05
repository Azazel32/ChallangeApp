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
            this.grades.Add(grade);
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
