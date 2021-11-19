using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse7_7
{
    class Kasseapparat
    {
        public void UdskrivBon(Vare[] varer)
        {
            foreach(Vare v in varer)
            {
                v.Udskriv();
            }
        }
    }
}
