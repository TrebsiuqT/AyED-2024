using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Quisbert_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pregunte al usuario su edad y muestre por pantalla todos
             los años que ha cumplido (desde 1 hasta su edad).
             */
            Console.WriteLine("Escribe tu edad");
            double edad = double.Parse(Console.ReadLine());
            int años = Convert.ToInt32(edad);
            int cumpleaños = 1;
            while(cumpleaños<años+1)
            {
                Console.WriteLine("Haz cumplido "+cumpleaños);
                cumpleaños++;
            }
            Console.ReadKey();
        }
    }
}
