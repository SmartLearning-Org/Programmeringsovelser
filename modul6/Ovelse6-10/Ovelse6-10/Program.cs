using System;

Console.WriteLine("Indtast 5 ord");
string[] ord = new string[5];

for (int i = 0; i < 5; i++)
{
    ord[i] = Console.ReadLine();
}

foreach (string s in ord)
{
    if (s.Length == 4)
    {
        Console.WriteLine(ord);
    }
}