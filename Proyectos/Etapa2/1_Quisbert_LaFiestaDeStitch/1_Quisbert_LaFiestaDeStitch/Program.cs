using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Quisbert_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lilo está organizando una fiesta para los aliens invitados 
             por Stitch y necesita gestionar la cantidad de comida necesaria.
             Para ello, ha creado un programa en C# que le ayudará a calcular 
             el promedio de comida que necesitará por invitado. El programa solicitará 
             al usuario que ingrese la cantidad de invitados y luego pedirá la cantidad 
             de comida que cada invitado consume, asegurándose de que los valores ingresados estén 
             dentro del rango permitido (de 1 a 100). Una vez que se hayan 
             ingresado todos los datos, el programa calculará el promedio de comida por invitado 
             y lo mostrará en pantalla

                El programa solicitará al usuario que 
                ingrese la cantidad de invitados a la fiesta.Luego, 
                para cada invitado, el programa solicitará que se ingrese la 
                cantidad de comida que come (un número entre 1 y 100), 
                asegurándose de que el valor ingresado esté dentro del rango permitido. 
                Si el valor ingresado no está dentro del rango, se mostrará un mensaje de error y 
                se pedirá que se ingrese nuevamente.Una vez que se hayan ingresado los datos de 
                todos los invitados, el programa calculará el promedio de comida por invitado.Finalmente, 
                el programa mostrará en pantalla el promedio de comida por invitado.*/

            //Definir variables
            int invitados;
            int cantidadComida;
            int promedio = 0;
            //Cantidad de invitados
            Console.WriteLine("Cuantos invitados asistiran a estafiesta??");
            invitados = int.Parse(Console.ReadLine());
            //Definir slots de la tupla
            int[] comidas = new int[invitados];
            //Cantidad de comida que come cada invitado
            for (int index = 0; index < invitados; index++)
            {
                //Cantidad de comida que come X invitado
                Console.WriteLine("Cuanta cantidad de comida comera el invitado N°" + (index + 1) + "??? ");
                Console.WriteLine("--------------------------------------------------------------------");
                cantidadComida = int.Parse(Console.ReadLine());
                //regular la cantidad de comida ingresada
                while (cantidadComida < 0 || cantidadComida > 100)
                {
                    //regulando
                    Console.WriteLine("ERROR, la comida debe ser MAYOR A CERO y MENOR A 100, nuevamente");
                    Console.WriteLine("Cuanta cantidad de comida comera el invitado N°" + (index + 1) + "???");
                    Console.WriteLine("--------------------------------------------------------------------");
                    cantidadComida = int.Parse(Console.ReadLine());
                }
                //Anotar en el vector
                comidas[index] = cantidadComida;
            }
            //La cantidad promedio de comida que comera cada invitado
            for (int indice = 0; indice < invitados; indice++)
            {
                promedio += comidas[indice];

            }
            Console.WriteLine("promedio de la cantidad: " + (promedio / invitados));
            Console.ReadKey();
        }
    }
}
