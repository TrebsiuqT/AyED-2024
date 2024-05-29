using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Quisbert_LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear 3 variables numéricas con el valor que tu quieras y en otra
            variable numérica guardar el valor de la suma de las 3 anteriores.
            Mostrar por consola.
             */

            //Solicitar valores de entradas
            Console.WriteLine("Asigne un valor para esta variable: A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Asigne un valor para esta variable: B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Asigne un valor para esta variable: C");
            double c = double.Parse(Console.ReadLine());
            //Sumatoria
            double sumatoriaflotante = (a+b+c);
            //Mostrar
            Console.WriteLine("Sumatoria de valores dados: "+sumatoriaflotante);
            Console.ReadKey();
        }
    }
}
