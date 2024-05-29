using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Quisbert_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribir un programa que almacene la cadena de caracteres contraseña en una variable, 
            pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida por el usuario 
            coincide con la guardada en la variable sin tener en cuenta mayúsculas y minúsculas.
            */
            bool pass = false;
            string word = "contraseña";
            while(pass==false)
            {
                Console.WriteLine("-----------Ingrese la contraseña--------");
                if (Console.ReadLine()==word)
                {
                    Console.WriteLine("Correcto");
                    pass = true;
                }
                else
                { Console.WriteLine("Incorrecto"); }
            }
                Console.ReadKey();
        }
    }
}
