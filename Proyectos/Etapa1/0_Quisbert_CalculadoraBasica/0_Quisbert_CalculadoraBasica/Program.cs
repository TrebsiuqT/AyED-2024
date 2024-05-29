using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Quisbert_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe un programa en C# que calcule el resultado de sumar, restar, multiplicar y 
            dividir dos números introducidos por el usuario.
            Además también debería calcular el resto de la división en la última linea.
            */

            //Escrbir en la consola
            Console.WriteLine("ingrese un par de valores");
            //Definir mis variables de entrada y convertir el dato como numero entero
            int valorUno = int.Parse(Console.ReadLine());
            int valorDos = int.Parse(Console.ReadLine());
            //Operadores y resultado

            Console.WriteLine("Sumatoria");
            Console.WriteLine(valorUno+" + "+valorDos+" = "+(valorUno+valorDos));

            Console.WriteLine("Restar");
            Console.WriteLine(valorUno + " - " + valorDos + " = " + (valorUno - valorDos));

            Console.WriteLine("Multiplicacion");
            Console.WriteLine(valorUno + " * " + valorDos + " = " + (valorUno * valorDos));

            Console.WriteLine("Division");
            Console.WriteLine(valorUno + " / " + valorDos + " = " + (valorUno / valorDos));

            Console.WriteLine("Division(Resto)");
            Console.WriteLine(valorUno + " / " + valorDos + " = " + (valorUno % valorDos));

            Console.ReadKey(); 
        }
    }
}
