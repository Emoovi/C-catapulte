using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLaGuerre
{
    class Trebuchet : ArmeDeJet
    {
        public Trebuchais(int Pdv)
        {
            base.Pdv = Pdv;
            Console.WriteLine(base.Pdv);
        }
    }
}
