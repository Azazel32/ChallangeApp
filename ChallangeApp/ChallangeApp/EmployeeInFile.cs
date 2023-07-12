

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
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
       
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int Counter = 0;
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.Average += number;
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        Counter++;
                        line = reader.ReadLine();
                    }
                    statistics.Average /= Counter;
                    switch (statistics.Average)
                    {
                        case var average when average >= 80:
                            {
                                statistics.AverageLetter = 'A';
                            }
                            break;
                        case var average when average >= 60:
                            {
                                statistics.AverageLetter = 'B';
                            }
                            break;
                        case var average when average >= 40:
                            {
                                statistics.AverageLetter = 'C';
                            }
                            break;
                        case var average when average >= 20:
                            {
                                statistics.AverageLetter = 'D';
                            }
                            break;
                        default:
                            {
                                statistics.AverageLetter = 'E';
                            }
                            break;
                    }
                }

            }
            return statistics;
        }
    }
}


