using System;

Console.WriteLine("Indtast tre tekster");
string[] tekster = new string[3];

for (int i = 0; i < 3; i++)
{
    tekster[i] = Console.ReadLine();
}


Array.Sort<string>(tekster, new Comparison<string>((s1, s2) => s1.Length.CompareTo(s2.Length)));