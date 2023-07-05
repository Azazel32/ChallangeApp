using ChallangeApp;
Employee employee_1 = new Employee("Kacper", "Nowak");
employee_1.AddGrade(6);
employee_1.AddGrade(8);
employee_1.AddGrade(10);
var statistics = employee_1.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");




