using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse7_10
{
    class Vejr
    {
        public int SamletNedbor(Regn dag1, Regn dag2)
        {
            int total = dag1.Nedbor + dag2.Nedbor;
            return total;
        }
    }
}
