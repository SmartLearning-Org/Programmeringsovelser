using System;

Console.WriteLine("Hvordan er vejret?");
string vejrtype = Console.ReadLine();

Console.WriteLine("Hvad er temperaturen?");
int temperatur = Convert.ToInt32(Console.ReadLine());

if (vejrtype == "sne" || temperatur < 0)
{
    Console.WriteLine("Jeg tror det er vinter");
}