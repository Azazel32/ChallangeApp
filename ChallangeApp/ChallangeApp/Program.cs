int number = 0;
Console.WriteLine("Podaj liczbe calkowita: ");
number = int.Parse(Console.ReadLine());
string numberInString = number.ToString();
char[] chars = numberInString.ToArray();
int number_0 = 0;
int number_1 = 0;
int number_2 = 0;
int number_3 = 0;
int number_4 = 0;
int number_5 = 0;
int number_6 = 0;
int number_7 = 0;
int number_8 = 0;
int number_9 = 0;
foreach (char letter in chars)
{
    if (letter == '0')
    {
        number_0++;
    }
    else if (letter == '1')
    {
        number_1++;
    }
    else if (letter == '2')
    {
        number_2++;
    }
    else if (letter == '3')
    {
        number_3++;
    }
    else if (letter == '4')
    {
        number_4++;
    }
    else if (letter == '5')
    {
        number_5++;
    }
    else if (letter == '6')
    {
        number_6++;
    }
    else if (letter == '7')
    {
        number_7++;
    }
    else if (letter == '8')
    {
        number_8++;
    }
    else if (letter == '9')
    {
        number_9++;
    }


}
Console.WriteLine("0-->" + number_0);
Console.WriteLine("1-->" + number_1);
Console.WriteLine("2-->" + number_2);
Console.WriteLine("3-->" + number_3);
Console.WriteLine("4-->" + number_4);
Console.WriteLine("5-->" + number_5);
Console.WriteLine("6-->" + number_6);
Console.WriteLine("7-->" + number_7);
Console.WriteLine("8-->" + number_8);
Console.WriteLine("9-->" + number_9);