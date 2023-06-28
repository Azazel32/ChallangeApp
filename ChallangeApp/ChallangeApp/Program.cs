using System;
string name;
int age;
string sexString;
bool sex;
Console.WriteLine("Podaj Imie :");
name = Console.ReadLine();
Console.WriteLine("Podaj wiek :");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj płeć Woman/Men:");
sexString = Console.ReadLine();
if (sexString=="Woman")
{
    sex = true;
}
else
{
    sex = false;
}
if (age < 30 && sex==true)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (age == 33 && name=="Ewa")
{
    Console.WriteLine("Ewa lat 33");
}
else if(age<18 && sex==false )
{
    Console.WriteLine("Niepolenoletni meszczyzna");
}
