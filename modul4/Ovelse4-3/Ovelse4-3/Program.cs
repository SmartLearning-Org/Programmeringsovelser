using System;

Console.WriteLine("Vil du have ananas på din pizza?");

string svar = Console.ReadLine();

if (svar == "Ja")
{
    Console.WriteLine("Det får du så");
} else if (svar == "Nej")
{
    Console.WriteLine("Okay, du bliver fri");
}