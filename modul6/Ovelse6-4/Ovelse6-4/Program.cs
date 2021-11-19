using System;

Console.WriteLine("Indtast tre ting du kan lide på salat");
string[] ingredienser = new string[3];

for (int i = 0; i < 3; i++)
{
    ingredienser[i] = Console.ReadLine();
}

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine(ingredienser[i]);
}

