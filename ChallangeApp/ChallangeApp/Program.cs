using ChallangeApp;

Employee employee_1 = new Employee("Kacper", "Nowak", "20");
Employee employee_2 = new Employee("Adam", "Kowalik", "34");
Employee employee_3 = new Employee("Jakub", "Mietczynski", "18");
List<Employee> employees = new List<Employee>() { employee_1, employee_2, employee_3};
Random rand = new Random();
foreach (Employee employee in employees)
for (int i = 0; i < 5; i++)
{
    employee.AddScore(rand.Next(1,11));
}
int index = 0;
for (int i = 1;i < 3; i++)
{
    if (employees[index].Result > employees[i].Result)
        index = i;
}
if (index != 0)
{
    Console.WriteLine(" Imie:" + employees[index].Name + " Nazwisko:" + employees[index].LastName +" wiek:" + employees[index].Age + " Punkty:"+ employees[index].Result);
}



