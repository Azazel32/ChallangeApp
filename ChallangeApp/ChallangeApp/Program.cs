using ChallangeApp;
Console.WriteLine("Witaj w programie do oceny pracownikow");
Console.WriteLine("======================================");
var employee_1 = new EmployeeInFile("Kacper", "Nowak",18);
employee_1.AddGrade(80);
employee_1.AddGrade(60);
employee_1.AddGrade(40);
void EmployeeGradeAdded(object sender,EventArgs args)
{
    Console.WriteLine("Dodano nowa ocena");
}
employee_1.GradeAdded += EmployeeGradeAdded;

while (true)
{
    Console.WriteLine("Podaj ocene: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else
    {
        try
        {
            employee_1.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
var statistics = employee_1.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine(statistics.AverageLetter);




