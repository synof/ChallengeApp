int number = 23001234;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int chars0 = 0;
int chars1 = 0;
int chars2 = 0;
int chars3 = 0;
int chars4 = 0;
int chars5 = 0;
int chars6 = 0;
int chars7 = 0;
int chars8 = 0;
int chars9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        chars0++;
    }
    else if (letter == '1')
    {
        chars1++;
    }
    else if (letter == '2')
    {
        chars2++;
    }
    else if (letter == '3')
    {
        chars3++;
    }
    else if (letter == '4')
    {
        chars4++;
    }
    else if (letter == '5')
    {
        chars5++;
    }
    else if (letter == '6')
    {
        chars6++;
    }
    else if (letter == '7')
    {
        chars7++;
    }
    else if (letter == '8')
    {
        chars8++;
    }
    else if (letter == '9')
    {
        chars9++;
    }
}
Console.WriteLine("Liczba " +number + " zawiera");
Console.WriteLine(" 0 ==> " + chars0);
Console.WriteLine(" 1 ==> " + chars1);
Console.WriteLine(" 2 ==> " + chars2);
Console.WriteLine(" 3 ==> " + chars3);
Console.WriteLine(" 4 ==> " + chars4);
Console.WriteLine(" 5 ==> " + chars5);
Console.WriteLine(" 6 ==> " + chars6);
Console.WriteLine(" 7 ==> " + chars7);
Console.WriteLine(" 8 ==> " + chars8);
Console.WriteLine(" 9 ==> " + chars9);
