using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse7_9
{
    class By
    {
        private string Navn;
        private int Indbyggertal;

        public By(string navn)
        {
            Navn = navn;
        }

        public By(String navn, int indbyggertal)
        {
            Navn = navn;
            Indbyggertal = indbyggertal;
        }
    }
}
