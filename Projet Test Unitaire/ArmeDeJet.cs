using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Test_Unitaire
{
    abstract class ArmeDeJet : IBreakAble{

        //https://dev18504.service-now.com/api/20557/catapulte/getlife?Name=G5

        protected int Pv;

        public int LifePoint(int Pv){
            return Pv;
        }

        public ArmeDeJet() { }
    }
}
