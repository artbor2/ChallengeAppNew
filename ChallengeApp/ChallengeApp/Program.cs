int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

int[] digits = new int[10]; // cyfry 0 - 9 

foreach(char c in letters)
{
    if (c == '0')
    {
        digits[0]++;
    }
    else if (c == '1')
    {
        digits[1]++;
    }
    else if (c == '2')
    {
        digits[2]++;
    }
    else if (c == '3')
    {
        digits[3]++;
    }
    else if (c == '4')
    {
        digits[4]++;
    }
    else if (c == '5')
    {
        digits[5]++;
    }
    else if (c == '6')
    {
        digits[6]++;
    }
    else if (c == '7')
    {
        digits[7]++;
    }
    else if (c == '8')
    {
        digits[1]++;
    }
    else if (c == '9')
    {
        digits[9]++;
    }
}

Console.WriteLine("Number: " + number);
for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine(i + " => " + digits[i]);
}
Console.WriteLine();
 