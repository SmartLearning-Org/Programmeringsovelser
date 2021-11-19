using System;

Console.WriteLine("Indtast fire tal");
int[] tal = new int[4];

for(int i = 0; i < 4; i++)
{
    tal[i] = Convert.ToInt32(Console.ReadLine());
}

int temp = tal[0];
tal[0] = tal[1];
tal[1] = temp;

temp = tal[2];
tal[2] = tal[3];
tal[3] = temp;

foreach(int t in tal)
{
    Console.WriteLine(t);
}