using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse7_6
{
    class Person
    {
        public String Navn { get; set; }
        public String Email { get; set; }

        public void Udskriv()
        {
            Console.WriteLine($"Navnet er {Navn} og e-mail-adressen er {Email}");
        }
    }
}
