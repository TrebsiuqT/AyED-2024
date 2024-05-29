using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Quisbert_CobraBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Para poder cobrar la beca JuanPedro se debe ser mayor de 
             19 años y tener unos ingresos iguales o superiores a $100.000 mensuales. 
             Escribir un programa que pregunte al usuario su edad y sus 
             ingresos mensuales y muestre por pantalla 
             si el usuario puede cobrar o no.
             */
            Console.WriteLine("Cuantos años tiene?...");
            if (double.Parse(Console.ReadLine()) > 19)
            {
                Console.WriteLine("Y cuanto son sus ingresos?");
                if (double.Parse(Console.ReadLine())>=100000)
                { Console.WriteLine("Puede retirar su beca"); }
                else { Console.WriteLine("Los ingresos son inferiores, No puedes retirar la beca"); }
            }
            else { Console.WriteLine("Su edad no supera los 19 años");  }
            Console.ReadKey();
        }
    }
}
