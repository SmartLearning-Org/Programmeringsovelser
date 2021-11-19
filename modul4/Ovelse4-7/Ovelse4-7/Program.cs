using System;

Console.WriteLine("Hvordan identificerer du dig inden for LGBTQ");
string identifikation = Console.ReadLine();

switch(identifikation)
{
    case "L": Console.WriteLine("Lesbian");
        break;
    case "G": Console.WriteLine("Gay");
        break;
    case "B": Console.WriteLine("Bisexual");
        break;
    case "T": Console.WriteLine("Transgender");
        break;
    case "Q": Console.WriteLine("Queer");
        break;
    default:
        Console.WriteLine("Uidentficeret");
        break;

}