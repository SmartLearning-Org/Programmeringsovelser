using System;

Console.WriteLine("Hvad er dit køn (mand/kvinde)");
String koen = Console.ReadLine();

Console.WriteLine("Hvad er din alder?");
int alder = Convert.ToInt32(Console.ReadLine());

if (koen == "kvinde")
{
    Console.WriteLine("Du er ikke i risikogruppen");
} else
{
    if (alder > 50)
    {
        Console.WriteLine("Du bør få en screening");
    } else
    {
        Console.WriteLine("Husk at blive screenet, når du bliver 50");
    }
}