using System;

Console.WriteLine("Indtast 5 tal");

int[] tal = new int[5];

for (int i = 0; i < 5; i++)
{
    tal[i] = Convert.ToInt32(Console.ReadLine());
}

foreach(int t in tal)
{
    if (t > 10)
    {
        Console.WriteLine(t);
    }
}