using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse7_7
{
    class Vare
    {
        public string Navn { get; set; }
        public double Pris { get; set; }

        public void Udskriv()
        {
            Console.WriteLine("{Navn}: {C2:Pris}");
        }
    }
}
