using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Quisbert_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pida al usuario un número entero 
             positivo y muestre por pantalla la cuenta atrás desde ese número hasta cero.
             */
            Console.WriteLine("-------Ingrese un numero positivo------");
            int x = Convert.ToInt32(Console.ReadLine());
           
            if (x<0)
            {
                Console.WriteLine("...");
              Console.ReadKey();
            }

            while (x >= 0)
            {
                Console.WriteLine("Restando...");
                Console.WriteLine(x);
                x--;
            }
            Console.ReadKey();
        }
    }
}
