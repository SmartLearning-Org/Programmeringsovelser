using System;

Console.WriteLine("Hvad koster varen?");

double pris = Convert.ToDouble(Console.ReadLine());

if (pris < 10)
{
    Console.WriteLine("Det er billigt");
} else if (pris > 100) {
    Console.WriteLine("Det er dyrt");
} else
{
    Console.WriteLine("Prisen er okay");
}