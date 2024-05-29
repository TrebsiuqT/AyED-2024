using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Quisbert_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir por consola un nombre 
             de persona y el nombre de una ciudad 
             (no hace falta que sean reales o comprobarlos) 
             y mostrar por pantalla, el siguiente 
             mensaje «Hola » <nombre> » bienvenido a » <ciudad>*/

            Console.WriteLine("Ingrese el nombre de una ciudad");
            String name = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre");
            String city = Console.ReadLine();
            Console.WriteLine("Hola "+name+" bienvenido a "+city);
            Console.ReadKey();
        }
    }
}
