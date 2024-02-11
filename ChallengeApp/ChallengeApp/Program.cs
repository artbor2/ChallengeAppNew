List<string> daysOfWeeks = new List<string>();
daysOfWeeks.Add("poniedziałek");
daysOfWeeks.Add("wtorek");
daysOfWeeks.Add("środa");
daysOfWeeks.Add("czwartek");
daysOfWeeks.Add("piątek");
daysOfWeeks.Add("sobota");
daysOfWeeks.Add("niedziela");


for (int i = 0; i < daysOfWeeks.Count; i++)
{
    Console.WriteLine(daysOfWeeks[i]);
}
Console.WriteLine();

foreach (string day in daysOfWeeks)
{
    Console.WriteLine(day);
}