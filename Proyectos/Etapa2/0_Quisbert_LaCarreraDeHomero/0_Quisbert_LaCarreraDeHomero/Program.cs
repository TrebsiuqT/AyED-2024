using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Quisbert_LaCarreraDeHomero
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            Homero Simpson está participando en una carrera de obstáculos. 
            Cada obstáculo tiene una dificultad diferente (representada por un número entero). 
            Ayuda a Homero a calcular su puntaje total.
            
            El usuario ingresa la cantidad de obstáculos.
            Homero debe superar cada obstáculo y sumar los puntos correspondientes, cada obstáculo 
            superado suma 10 puntos, cada obstáculo NO superado resta 5.
            (Debe aparecer un mensaje por cada obstáculo diciendo 
            "OBSTACULO X, lo supera?" y el usuario debe responder si o no) 
             */

            //Total
            int total = 0;
            //
            string respuesta;
            //Empieza el juego
            Console.WriteLine("Homero esta a punto de empezar una carrera");
            //Preguntar cuantos obstaculos a ganerar
            Console.WriteLine("Cuantos obstaculos tiene esta carrera?");
            int obstaculos = int.Parse(Console.ReadLine());
            //Espacios de Puntages
            int[] score = new int[obstaculos];
            //Secuencia de preguntas
            Console.WriteLine("Homero ha empezado la carrera");
            for (int i = 0; i < obstaculos; i++)
            {
                //Esperar la respesta
                Console.WriteLine("El obstaculo " + i + " lo supera? SI o NO");
                respuesta = Console.ReadLine();
                while(respuesta != "SI" && respuesta != "NO")
                {
                    Console.WriteLine("SI o NO");
                    respuesta = Console.ReadLine();
                }
                Console.WriteLine("ok");
                //Estimular respuesta
                if (respuesta == "SI")
                {
                    Console.WriteLine("Homero supero el obstaculo. +10");
                    score[i] = 10;
                }
                else if (respuesta == "NO")
                {
                    Console.WriteLine("Homero no supero el obstaculo. -5");
                    score[i] = -5;
                }
                total += score[i];
            }

            Console.WriteLine("La puntuacion de homero es: "+total);
            Console.ReadKey();








        }
    }
}
