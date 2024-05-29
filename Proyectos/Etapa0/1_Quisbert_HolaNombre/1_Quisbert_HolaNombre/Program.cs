using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Quisbert_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su noombre");
            String name = Console.ReadLine();
            
            Console.WriteLine("Hola, "+name);
            Console.ReadKey();
        }
    }
}
