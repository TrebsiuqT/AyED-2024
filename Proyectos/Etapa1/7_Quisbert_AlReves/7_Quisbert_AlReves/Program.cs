using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Quisbert_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.
            Console.WriteLine("Escribe 3 letras lo que te salga de la gana");
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            String c = Console.ReadLine();
            Console.WriteLine(c+" "+b+" "+a);
            Console.ReadKey();
        }
    }
}
