using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Quisbert_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Recorre los números del 1 al N. (N lo tiene que ingresar el usuario).
             Muestra solamente los números pares.
             */
            Console.WriteLine("Ingrese un numero natural");
            Console.WriteLine("-------------------------");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            int r = 1;
            do
            {
                if (r%2==0)
                {Console.WriteLine(r);}
                r++;
            } while (n != r);
            Console.ReadKey();
           
        }
    }
}
