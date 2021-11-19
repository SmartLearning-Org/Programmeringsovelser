using System;
using System.Linq;

Console.WriteLine("Indtast 5 tekster");
string[] tekster = new string[5];
for (int i = 0; i < 5; i++)
{
    tekster[i] = Console.ReadLine();
}

Random random = new();
tekster = tekster.OrderBy(x => random.Next()).ToArray();

foreach (string tekst in tekster)
{
    Console.WriteLine(tekst);
}