using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Quisbert_TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir V
            String cadena = "15.557294";
            int entero = int.Parse(Console.ReadLine());
            bool booleon = false;
            float flotante = 15.557294f;
            double doble = 15.557294;
            char caracter = '1';
            //Escribir
            Console.WriteLine("String: "+cadena);
            Console.WriteLine("int: "+entero);
            Console.WriteLine("bool: "+booleon);
            Console.WriteLine("float: "+flotante);
            Console.WriteLine("double: "+doble);
            Console.WriteLine("char: "+caracter);
            
            //Detercar tecla
            Console.ReadKey();

        }
    }
}
