using System;

Console.WriteLine("Indtast et beløb");
double belob = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Prisen er {belob:N2}");