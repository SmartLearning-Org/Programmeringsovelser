using System;

Console.WriteLine("Hvor mange sider indeholder dokumentet?");

int sideantal = Convert.ToInt32(Console.ReadLine());

int besparelse = sideantal / 2;

Console.WriteLine($"Du kan spare {besparelse} sider ved dobbeltsidet udskrift.");