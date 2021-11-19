using System;

Console.WriteLine("Hvor mange ting husker du på?");
int antal = Convert.ToInt32(Console.ReadLine());

string[] huskeliste = new string[antal];
for (int i = 0; i < antal; i++)
{
    huskeliste[i] = Console.ReadLine();
}

foreach (string ting in huskeliste)
{
    Console.WriteLine(ting);
}