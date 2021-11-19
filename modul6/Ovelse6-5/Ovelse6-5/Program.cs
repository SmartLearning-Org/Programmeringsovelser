using System;

Console.WriteLine("Indtast navnet på tre venner");
string[] venner = new string[3];

for (int i = 0; i < 3; i++)
{
    venner[i] = Console.ReadLine();
}

foreach(string ven in venner)
{
    if (ven == "Kristian")
    {
        Console.WriteLine("Godt du huskede mig");
    }
}
