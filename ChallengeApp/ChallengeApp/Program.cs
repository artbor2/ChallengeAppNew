int[] grades = new int[5];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";
Console.WriteLine(dayOfWeeks[2]);

string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa",
                         "czwartek", "piatek", "sobota", "niedziela"};

Console.WriteLine(dayOfWeeks2[0]);

for (int i = 0; i < 10; i = i + 1)
{
    Console.Write(i + " ");
}
Console.WriteLine('\n');

for (int i = 0;i < dayOfWeeks.Length; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
Console.WriteLine();

for (int i = 0; i < dayOfWeeks.Length; i = i + 2)
{
    Console.WriteLine(dayOfWeeks[i]);
}