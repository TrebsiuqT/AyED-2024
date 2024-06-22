using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Quisbert_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            La compañía de videojuegos "ZEGA" está desarrollando un nuevo 
            juego de rol (RPG) en el que los jugadores pueden encontrar 
            objetos con diferentes valores. Necesitan un 
            programa que permita identificar en qué posición se encuentran los 
            objetos cuyo valor es mayor a un número dado.

            El programa solicitará al usuario que ingrese la cantidad 
            de elementos (objetos) que desea analizar.Luego, pedirá al 
            usuario que ingrese el valor mínimo que deben tener los objetos 
            para ser considerados en el filtro.Seguidamente, el programa 
            solicitará al usuario que ingrese los valores de los objetos, 
            uno por uno.Una vez ingresados todos los valores, el programa
            mostrará al usuario las posiciones en las que se encuentran 
            los objetos cuyo valor es mayor al número especificado.
            */

            //Preparar
            Console.Write("Que cantidad de elementos que habra en el inventario? ");
            int objs = int.Parse(Console.ReadLine());

            float[] vector = new float[objs];

            Console.Write("Ingrese el valor minimo de los objetos... ");
            int min = int.Parse(Console.ReadLine());


            //Ej.
            //Random x = new Random();
            //int y = x.Next(0, 10);

            //Lanzar dados
            Random dado = new Random();
            for (int i = 0; i < objs; i++)
            {
                vector[i] = dado.Next(0, 999);
            }

            //Mostreo
            Console.WriteLine("--------Inventario------");
            for (int i = 0; i < objs; i++)
            {
                Console.WriteLine("Objeto N°" + (1 + i) + "... " + vector[i]);
            }
            Console.WriteLine("------------------------");

            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("------Valores > minimo valor--------");
            for (int i = 0; i < objs; i++)
            {
                if (vector[i] > min)
                {
                    Console.WriteLine("Obj N°"+(i+1)+" = "+vector[i]);
                }
            }

            //Console.WriteLine("Los valores de los objetos son de el VALOR MINIMO hasta 999! o sea ningun valor sera menor al valor dado");
            Console.ReadKey();
        }
    }
}
