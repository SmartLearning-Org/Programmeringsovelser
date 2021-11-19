using System;

Console.WriteLine("Hvad er dit køn (mand/kvinde)");
string koen = Console.ReadLine();

Console.WriteLine("Hvor gammel er du?");
int alder = Convert.ToInt32(Console.ReadLine());

string aldersgruppe = "";
if (alder < 18)
{
    aldersgruppe = "junior";
} else
{
    aldersgruppe = "senior";
}

string koengruppe = "";
if (koen == "mand")
{
    koengruppe = "herreholdet";
} else
{
    koengruppe = "dameholdet";
}

Console.WriteLine($"Du skal spille på {aldersgruppe} {koengruppe}");