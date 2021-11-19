using System;
using System.Linq;

int[] tal = new int[13];
for (int i = 0; i < 13; i++)
{
    tal[i] = i + 1;
}

Random random = new();
tal = tal.OrderBy(x => random.Next()).ToArray();

foreach(int t in tal)
{
    Console.WriteLine(t);
}