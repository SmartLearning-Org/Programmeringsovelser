using System;

int[] tal = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Indtast et tal");
    tal[i] = Convert.ToInt32(Console.ReadLine());

    for(int j = 0; j <= i; j++)
    {
        Console.WriteLine(tal[j]);
    }
}