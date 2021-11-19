using System;

int[] tal = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Indtast et tal");
    tal[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Du har indtil videre indtastet disse tal:");
    for (int j = 0; j <= i; i++)
    {
        Console.WriteLine(tal[j]);
    }
}