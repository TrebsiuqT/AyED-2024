using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Quisbert_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe un programa en C# que pregunte al usuario por un número x y 
             muestre el resultado de su tabla de multiplicar del 1 al 10.
             */
             Console.WriteLine("Ingrese un numero para mostrar su tabla de multiplicacion");
            double numero = double.Parse(Console.ReadLine());
            int factor = 1;
            while(factor < 11)
            {
                Console.WriteLine(numero+" x "+factor+" = "+(numero*factor));
                factor += 1;
            }
            Console.ReadKey();
        }
    }
}
