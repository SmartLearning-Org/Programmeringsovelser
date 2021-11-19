using System;

Console.WriteLine("Indtast 5 tal");
int[] tal = new int[5];

for (int i = 0; i < 5; i++)
{
    tal[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(tal);
Array.Reverse(tal);

foreach (int t in tal)
{
    Console.WriteLine(t);
}
