using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Test_Unitaire
{
    class Program{
        static void Main(string[] args){

            Pairs<string, int> UnePair = new Pairs<string, int>("Spoon", 0);
            Pairs<string, int> UnePair2 = new Pairs<string, int>("Arm", 16);
            Pairs<string, int> UnePair3 = new Pairs<string, int>("Beam", 19);
            Pairs<string, int> UnePair4 = new Pairs<string, int>("Rope", 400);
            Pairs<string, int> UnePair5 = new Pairs<string, int>("Trigger", -3);

            string[] array = new string[] { UnePair.ToString(), UnePair2.ToString(), UnePair3.ToString(), UnePair4.ToString(), UnePair5.ToString() };

            for (int i=0; i<5; i++){
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }        
    }
}
