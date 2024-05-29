using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Quisbert_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que pida al 
            usuario un número entero y muestre por pantalla si es par o impar*/
            Console.WriteLine("----Introduzca un numero----");
            if( double.Parse(Console.ReadLine())%2 == 0)
                { Console.WriteLine("Es un numero par"); }
            else { Console.WriteLine("Es un numero impar");  }
            Console.ReadKey();
        }
    
    }
}
