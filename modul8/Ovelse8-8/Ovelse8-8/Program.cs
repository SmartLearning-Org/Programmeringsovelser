using System;

string[] storrelse = new string[] { "kæmpestor", "stor", "lille", "lillebitte" };
string[] farve = new string[] { "rød", "gul", "grøn" };
string[] type = new string[] { "kasse", "bold", "rygsæk", "bil", "legeplads" };

Random random = new();

for (int i = 0; i < 10; i++)
{
    int storrelseTal = random.Next(0, storrelse.Length - 1);
    int farveTal = random.Next(0, farve.Length - 1);
    int typeTal = random.Next(0, type.Length - 1);

    Console.WriteLine($"En {storrelse[storrelseTal]} {farve[farveTal]} {type[typeTal]}");
}