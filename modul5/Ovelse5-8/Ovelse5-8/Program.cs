using System;

for (int linje = 1; linje < 11; linje++)
{
    for (int tal = linje; tal < linje * 10 + 1; tal = tal + linje)
    {
        Console.Write($"{tal} ");
    }
    Console.WriteLine();
}
