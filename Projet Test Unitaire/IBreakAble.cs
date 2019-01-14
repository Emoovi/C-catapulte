using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Test_Unitaire
{
    interface IBreakAble{

        int LifePoint(int Pv);

        //bool Operational();
        //int Pv { get; set; }
    }

    public class BrokenException : Exception{
        public BrokenException(string element) : base("Cet Element n'a plus de point de vie : " + element){ }
    }
}
