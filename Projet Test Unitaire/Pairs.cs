using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Test_Unitaire{
    class Pairs<U, T>{

        private U piece;
        private T pv;

        public U getPiece() { return this.piece; }
        public T getPv() { return this.pv; }

        public Pairs(U piece, T pv){
            this.piece = piece;
            this.pv = pv;
        }

        public override string ToString(){

            return "Piece : " + getPiece() + ", PV : " + getPv();
        }
    }
}
