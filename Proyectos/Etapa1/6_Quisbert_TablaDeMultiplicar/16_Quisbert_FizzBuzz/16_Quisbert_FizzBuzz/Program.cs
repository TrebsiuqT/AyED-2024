using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Quisbert_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe un programa que muestre por consola (con un print) 
             los  números de 1 a 100 (ambos incluidos y con un salto de línea entre  
             cada impresión), sustituyendo los siguientes: 
             - Múltiplos de 3 por la palabra "fizz". 
             - Múltiplos de 5 por la palabra "buzz". 
             - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
             */
            int numero = 1;
            while(numero<101)
            {
                if ( numero%3==0 && numero%5==0)
                {
                    Console.WriteLine(numero + " FizzBuzz");
                }
                else
                {
                    if (numero%3==0)
                    {
                        Console.WriteLine(numero + " Fizz");
                    }
                    else
                    {
                        if (numero%5==0)
                        {
                            Console.WriteLine(numero + " Buzz"); 
                        }
                        else
                        {
                            Console.WriteLine(numero);
                        }
                    }
                }
               
                Console.WriteLine();
                numero++;
            }
            Console.ReadKey();
        }
    }
}
