using System;

Console.WriteLine("Indtast 5 tal");
int[] tal = new int[5];
for (int i = 0; i < tal.Length; i++)
{
    tal[i] = Convert.ToInt32(Console.ReadLine());
}

int antal = 0;
foreach (int t in tal)
{
    if (t < 5)
    {
        antal++;
    }
}

Console.WriteLine($"Der er {antal} tal mindre end 5");