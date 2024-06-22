using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Quisbert_ConstratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             El programa solicitará al usuario que ingrese la cantidad 
             de candidatos que realizaron el examen.Luego, pedirá al 
             usuario que ingrese los puntajes de cada candidato, 
             uno por uno.Una vez ingresados todos los puntajes, el 
             programa los ordenará de menor a mayor.Posteriormente, el 
             programa solicitará al usuario que ingrese un número entero
             para filtrar los puntajes múltiplos de ese número.Finalmente,
             mostrará al usuario la lista de puntajes ordenados y los puntajes
             que son múltiplos del número especificado.
             */


            //begin
            Console.Write("Numero de participantes del examen... ");
            int participantes = int.Parse(Console.ReadLine());

            int[] vector = new int[participantes];

            //dados
            Random dado = new Random();

            for (int i = 0; i < participantes; i++)
            {
                vector[i] = dado.Next(0, 100);
            }

            //tabla

            Console.WriteLine("------Tabla de calificaciones-------");
            for (int i = 0; i < participantes; i++)
            {
                Console.WriteLine("Participante N°" + (i + 1) + " -> puntaje = " + vector[i]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //sort

            for (int i = 0; i < participantes; i++)
            {
                for (int y = i; y < participantes; y++)
                {
                    if (vector[i] > vector[y])
                    {
                        int aux = vector[i];
                        vector[i] = vector[y];
                        vector[y] = aux;
                    }
                }
            }

            Console.WriteLine("------Tabla de calificaciones Sort-------");
            for (int i = 0; i < participantes; i++)
            {
                Console.WriteLine("Participante N°" + (i + 1) + " -> puntaje = " + vector[i]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //add me
            Console.Write("Ingrese un numero cuyo obj sera el multiplo -> ");
            int multiplo = int.Parse(Console.ReadLine());
            bool rta = false;
            for (int i = 0; i < participantes; i++)
            {
                if ((vector[i] % multiplo) == 0)
                {
                    Console.WriteLine(vector[i] + " es multiplo de " + multiplo);
                    rta = true;
                }
                
            }
            if (rta == false)
            {
                Console.WriteLine("NO existe ningun valor que sea multiplico de dicho numero");
            }
            Console.WriteLine("-Los valores son aleatorios");
            Console.ReadKey();
        }
    }
}
