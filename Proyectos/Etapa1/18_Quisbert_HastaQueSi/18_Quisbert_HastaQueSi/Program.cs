using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Quisbert_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriba un programa que pregunte una y otra 
            vez si desea terminar el programa, salvo si 
            se contesta exactamente SI (en mayúsculas y 
            sin tilde). 
             */

            string si = "SI";
            do
            {
                Console.WriteLine("desea terminar el programa, escriba SI");
            } while (si!=Console.ReadLine() );
        }
    }
}
