using System;

namespace Ovelse8_2
{
    class Program
    {
        private void UdskrivTekst(int antalFlasker)
        {
            Console.WriteLine($"{antalFlasker} bottles of beer on the wall, {antalFlasker} bottles of beer.");
            Console.WriteLine($"Take one down and pass it around, {antalFlasker - 1} bottles of beer on the wall.");
            Console.WriteLine();
            if (antalFlasker > 1)
            {
                UdskrivTekst(antalFlasker - 1);
            }            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
