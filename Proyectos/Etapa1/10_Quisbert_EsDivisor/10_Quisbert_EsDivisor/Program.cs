using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Quisbert_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribir un programa que pida al usuario dos números 
            y muestre por pantalla su división. 
            Si el divisor es cero el programa debe mostrar un error
            */
            Console.WriteLine("-----Ingresar un dividendo-----");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("-----Ingresar un divisor-----");
            double y = double.Parse(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("-----SOLUCION-----");
                Console.WriteLine(x + " / " + y + " = Error");
            }
            else {
                Console.WriteLine("-----SOLUCION-----");
                Console.WriteLine(x + " / " + y + " = " + (x/y));
               }
            Console.ReadKey();
        }
    }
}
