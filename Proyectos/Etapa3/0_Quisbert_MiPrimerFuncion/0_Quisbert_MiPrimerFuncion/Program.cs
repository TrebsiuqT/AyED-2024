using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Quisbert_MiPrimerFuncion
{
    class Program
    {

        static string saludar (string nombre)
        {
            string variable = "hola " + nombre;
            return (variable);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("tu nombre?");
            string tu = Console.ReadLine();
            Console.Write(saludar(tu));
            Console.ReadKey();
        }
    }
}
