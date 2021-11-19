using System;

Console.WriteLine("Indtast værdien af et kort (1-13)");
int kort = Convert.ToInt32(Console.ReadLine());

switch(kort)
{
    case 1: Console.WriteLine("Es");
        break;
    case 11: Console.WriteLine("Knægt");
        break;
    case 12: Console.WriteLine("Dame");
        break;
    case 13: Console.WriteLine("Konge");
        break;
    default:
        Console.WriteLine($"{kort}'er");
        break;
}