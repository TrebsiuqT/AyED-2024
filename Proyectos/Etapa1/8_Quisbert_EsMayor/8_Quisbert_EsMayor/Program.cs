using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Quisbert_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no
            Console.WriteLine("Introduzca su edad");
            int old = int.Parse(Console.ReadLine());
            if (old>=18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
