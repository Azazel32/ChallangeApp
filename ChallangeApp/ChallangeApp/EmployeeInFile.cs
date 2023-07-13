

namespace ChallangeApp
{
    public class EmployeeInFile:EmployeeBase
    {
        private const string fileName  = "grade.txt";
        public EmployeeInFile(string name, string lastname, int age)
            : base(name, lastname, age)
        {

        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    {
                        this.AddGrade(100);
                    }
                    break;
                case 'B':
                case 'b':
                    {
                        this.AddGrade(80);
                    }
                    break;
                case 'C':
                case 'c':
                    {
                        this.AddGrade(60);
                    }
                    break;
                case 'D':
                case 'd':
                    {
                        this.AddGrade(40);
                    }
                    break;
                case 'E':
                case 'e':
                    {
                        this.AddGrade(20);
                    }
                    break;
                default:
                    throw new Exception("Wrong Letter Try Letter betwen A-E");
            }
        }

        public override void AddGrade(double grade)
        {
            if (float.MaxValue >= grade && float.MinValue <= grade)
            {
                AddGrade((float)grade);
            }
            else
            {
                throw new Exception("  Przekroczenie zasięgu FLOAT!");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                OnGradeAdded();
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
       
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while ((line=reader.ReadLine()) != null)
                    {
                        var grade = float.Parse(line);
                        statistics.AddGrade(grade);
                    }
                    
                }

            }
            return statistics;
        }
    }
}


