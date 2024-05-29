using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Quisbert_DiezVeses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribir un programa que pida al usuario una palabra y la muestre por pantalla 10 veces    
            */
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            int x = 1;
            while(x<11)
            {
              Console.WriteLine(x+". "+palabra);
              x += 1;
            }
            Console.ReadKey();
        }
    }
}
