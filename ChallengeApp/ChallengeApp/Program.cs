string name = "Agnieszka";
bool male = true;
int age = 20  ;

if ((male == false) && (age < 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
} 

if (name == "Ewa" && (age == 30))
{
    Console.WriteLine(name + ", lat " + age);
}

if (male &&  (age < 18))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
