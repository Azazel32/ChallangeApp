int number = 0;
Console.WriteLine("Podaj liczbe calkowita: ");
number = int.Parse(Console.ReadLine());
string numberInString = number.ToString();
char[] chars = numberInString.ToArray();
List<int> counter = new List<int>();
foreach (char letter in chars)
{
    if (letter == '0') counter[0]++;
    else if (letter == '1') counter[1]++;
    else if (letter == '2') counter[2]++;
    else if (letter == '3') counter[3]++;
    else if (letter == '4') counter[4]++;
    else if (letter == '5') counter[5]++;
    else if (letter == '6') counter[6]++;
    else if (letter == '7') counter[7]++;
    else if (letter == '8') counter[8]++;
    else if (letter == '9') counter[9]++;
}
foreach (int i in counter)
{
    Console.WriteLine(i + "-->" + counter[i]);
}