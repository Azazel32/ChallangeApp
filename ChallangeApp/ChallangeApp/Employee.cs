using System.Diagnostics;

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
                Console.WriteLine("String is not float");
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
        public Statistics GetStatisticsWithForEach()
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
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Average += this.grades[i];
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            int index = 0;
            while (index<=this.grades.Count) 
            {
                statistics.Average += grades[index];
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                index++;
            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            int index = 0;
            do
            {
                statistics.Average += grades[index];
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                index++;
            } while (index <= grades.Count);
            statistics.Average /= grades.Count;
            return statistics;
        }






    }
}
