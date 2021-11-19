using System;

Console.WriteLine("Indtast tre varer og deres pris");
string[] varer = new string[3];
double[] priser = new double[3];

for (int i = 0; i < 3; i++)
{
    varer[i] = Console.ReadLine();
    priser[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{varer[i]} koster {priser[i]} kr.");
}