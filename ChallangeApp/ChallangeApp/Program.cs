using ChallangeApp;
Employee employee_1 = new Employee("Kacper", "Nowak");
employee_1.AddGrade(6);
employee_1.AddGrade(8);
employee_1.AddGrade(10);
var statistics1 = employee_1.GetStatisticsWithForEach();
var statistics2 = employee_1.GetStatisticsWithDoWhile;
var statistics3 = employee_1.GetStatisticsWithWhile;
var statistics4 = employee_1.GetStatisticsWithFor();
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Average: {statistics1.Average:N2}");




