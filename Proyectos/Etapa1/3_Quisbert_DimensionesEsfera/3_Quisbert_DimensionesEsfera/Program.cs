using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Quisbert_DimensionesEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crea un programa en C# 
             para calcular la superficie y el volumen 
             de una esfera, dado su radio.
             superficie = 4 * pi * radio al cuadrado
             volumen = 4/3 * pi * radio al cubo*/
            Console.WriteLine("ingreser un valor para un radio");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("La superficie es: "+(4*3.14*radio*radio)+" El volumen esferico es: "+(1.333*3.14*radio*radio*radio));
            Console.ReadKey();
        }
    }
}
