using System;

string navn;
int antal = 0;
do
{
    Console.WriteLine("Skriv navnet på en gæst");
    navn = Console.ReadLine();
    antal++;
} while (navn != "");

antal--; // fordi vi talte en for meget i den blank linje til sidst
Console.WriteLine($"Der kommer {antal} gæster");
