using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Quisbert_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            El Rayo McQueen está compitiendo en una carrera de alta velocidad. 
            Necesita un programa en C# que le ayude a registrar los tiempos de cada vuelta y 
            calcular algunas estadísticas importantes. 

            El programa debe:
            Permitir a Rayo McQueen ingresar los tiempos de cada vuelta de 
            la carrera en segundos. Utiliza un array para almacenar estos tiempos.
            Calcular y mostrar en pantalla el tiempo total de la carrera.
            Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
            Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, 
            la vuelta con el menor tiempo registrado.
            El programa debe permitir al usuario ingresar la cantidad de vueltas que completó 
            Rayo McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.
            */

            //Obj
            float ayudante;
            float total = 0;
            float promedio;
            int vueltas;
            //Preparando
            Console.WriteLine("El Rayo McQueen esta compitiendo una carrera.");
            Console.WriteLine("Cuantas vueltas tiene esta carrera??");
            vueltas = int.Parse(Console.ReadLine());
            float[] tiempos = new float[vueltas];
            Console.WriteLine("-------------------La carrera comenzo----------------------------");
            //Serie de preguntas
            for (int indice = 0; indice < vueltas; indice++)
            {
                Console.WriteLine("... Cuantos segundos duro la N°" + (indice + 1) + " vuelta de McQueen?");
                tiempos[indice] = float.Parse(Console.ReadLine());
                Console.WriteLine("--------------------Empieza la N°" + (indice + 1) + " vuelta----------------------------------");
            }
            //Calcular el tiempo total de la carrera
            for (int indice = 0; indice < vueltas; indice++)
            {
                total += tiempos[indice];
            }
            //Calcular el promedio
            promedio = total/vueltas;
            //Calculando el meno tiempo.
            ayudante = tiempos[0];
            for (int indice = 1; indice < vueltas; indice++)
            {
                if (ayudante > tiempos[indice])
                { ayudante = tiempos[indice]; }
            }
            //Mostro
            Console.WriteLine("_____________ESTADISTICAS_______________");
            Console.WriteLine("Tiempo total de la carrera:        "+total);
            Console.WriteLine("Promedio el tiempo de las vueletas:"+promedio);
            Console.WriteLine("La vuelta con menor tiempo:        "+ayudante);
            Console.WriteLine("________________________________________");
            Console.ReadKey();
        }
    }
}
