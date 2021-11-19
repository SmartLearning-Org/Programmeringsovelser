using System;

Console.WriteLine("Hvordan er vejret?");
string vejr = Console.ReadLine();

Console.WriteLine("Hvor mange grader er det?");
int grader = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Det er {vejr} og {grader} grader");
