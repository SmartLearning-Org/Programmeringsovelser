using System;

namespace Ovelse8_2
{
    class Program
    {
        private int Fakultet(int tal)
        {
            if (tal > 1)
            {
                return tal * Fakultet(tal - 1);
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
