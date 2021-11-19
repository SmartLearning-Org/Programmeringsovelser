using System;

Console.WriteLine("Skriv tre ting, du kan lide");
string[] ting = new string[3];

for (int i = 0; i < 3; i++)
{
    ting[i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    int prioritet = i + 1;
    Console.WriteLine($"{prioritet}. {ting[i]}");
}