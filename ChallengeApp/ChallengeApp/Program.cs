// ==  != < > <= >=
// && || !

var name = "Adam";
var age = 33;

if (name == "Adam" && age < 50)
{
    Console.WriteLine("JESTEM ADAMEM PRZED 50");
}
else
{
    Console.WriteLine("JESTEM KIMŚ INNYM");
}

if (name == "Adam" || age < 50)
{
    Console.WriteLine("JESTEM ADAMEM LUB MAM MNIEJ NIŻ 50");
}
else
{
    Console.WriteLine("JESTEM KIMŚ INNYM");
}

bool isTrue = true;
Console.WriteLine(isTrue);
Console.WriteLine(!isTrue);