using Ovelse7_10;
using System;

Regn mandag = new();

mandag.Dag = "Mandag";
mandag.Nedbor = 7;

Regn tirsdag = new();
tirsdag.Dag = "Tirsdag";
tirsdag.Nedbor = 5;

Vejr vejr = new();
int samletNedbor = vejr.SamletNedbor(mandag, tirsdag);
Console.WriteLine($"Den samlede nedbør er {samletNedbor} mm");