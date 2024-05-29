using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Quisbert_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Preparacion
            Console.WriteLine("Cuantos participantes hay en el torneo");
            int jugadores = int.Parse(Console.ReadLine());
            float[] vector = new float[jugadores];
            Console.WriteLine("---Ingrese los puntajes de los jugadores---");
            //Asignar puntajes
            for (int i = 0; i < jugadores; i++)
            {
                Console.WriteLine("Puntaje del jugador N°" + (i + 1) + " es de...");
                vector[i] = float.Parse(Console.ReadLine());
            }
            //Metodo Burbuja
            for (int i = 0; i < jugadores; i++)
            {
                for (int y = i+1; y < jugadores; y++)
                {
                    if (vector[y] > vector[i])
                    {
                        float aux = vector[i];
                        vector[i] = vector[y];
                        vector[y] = aux;
                    }
                }
            }
            //Mostrar
            Console.WriteLine("");
            Console.WriteLine("________Lista de puntajes_________");
            for (int i = 0; i < jugadores; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Puntaje del jugador N°" + (i) + ": " + vector[i] + " Most Score");
                }
                else if (i == (jugadores-1) )
                {
                    Console.WriteLine("Puntaje del jugador N°" + (i) + ": " + vector[i] + " Less Score");
                }
                else
                {
                    Console.WriteLine("Puntaje del jugador N°" + (i + 1) + ": " + vector[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
