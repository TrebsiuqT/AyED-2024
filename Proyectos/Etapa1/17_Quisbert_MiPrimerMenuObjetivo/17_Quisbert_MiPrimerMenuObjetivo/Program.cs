using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Quisbert_MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Crear un programa en C# que presente un menú con diversas opciones 
                simples y permita al usuario seleccionar una de ellas.

                Descripción:
                Se solicita crear un programa en C# que muestre un menú 
                con al menos tres opciones simples y permita al usuario 
                seleccionar una de ellas. Cada opción debe realizar una 
                acción diferente, como mostrar un mensaje en pantalla o 
                realizar un cálculo básico.

                Requerimientos:
                Mostrar un mensaje de bienvenida al programa.
                Presentar un menú con al menos tres opciones numeradas.
                Permitir al usuario seleccionar una opción ingresando el número correspondiente.
                Realizar una acción diferente para cada opción seleccionada.
                Repetir el proceso hasta que el usuario elija una opción para salir del programa.


                Ejemplo de Menú:

                --- Menú ---
                1. Opción 1
                2. Opción 2
                3. Opción 3
                4. Salir 
             */

            //Definir variables
            bool salir = false;
            bool menu = false;
            bool opcionUno = false;
            bool opcionDos = false;
            bool opcionTres = false;

            int eleccion = 0;
            //Mientras se ejecute el programa
            while (salir == false)
            {
                //Cambio de valores
                if (eleccion == 0) //Activar menu
                {
                    menu = true;
                    opcionUno = false;
                    opcionDos = false;
                    opcionTres = false;
                }
                else if (eleccion == 1) //Activar Op1
                {
                    menu = false;
                    opcionUno = true;
                    opcionDos = false;
                    opcionTres = false;
                }
                else if (eleccion == 2) //Activar Op2
                {
                    menu = false;
                    opcionUno = false;
                    opcionDos = true;
                    opcionTres = false;
                }
                else if (eleccion == 3) //Activar Op3
                {
                    menu = false;
                    opcionUno = false;
                    opcionDos = false;
                    opcionTres = true;
                }
                else if (eleccion == 4) //Salir
                {
                    menu = false;
                    opcionUno = false;
                    opcionDos = false;
                    opcionTres = false;
                    salir = true;
                }

                if (menu)
                {
                    //Mostrar 
                    Console.WriteLine("Bienvenido, eliga un opcion ingresando el indice:");
                    Console.WriteLine("1. Opcion 1");
                    Console.WriteLine("2. Opcion 2");
                    Console.WriteLine("3. Opcion3");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine();
                    //Elegir opcion por medio de la variable.
                    Console.WriteLine("Ingrese su respuesta");
                    eleccion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (opcionUno)
                {
                    //Mostrar
                    Console.WriteLine("Mostrar tonteria 1");
                    Console.WriteLine();
                    Console.WriteLine("------opciones-----");
                    Console.WriteLine("0. menu");
                    Console.WriteLine("2. Opcion 2");
                    Console.WriteLine("3. Opcion 3");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese su respuesta:");
                    eleccion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (opcionDos)
                {
                    Console.WriteLine("mostrar tonteria 2");
                    Console.WriteLine();
                    Console.WriteLine("------opciones-----");
                    Console.WriteLine("0. menu");
                    Console.WriteLine("1. Opcion 1");
                    Console.WriteLine("3. Opcion 3");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese su respuesta:");
                    eleccion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (opcionTres)
                {
                    Console.WriteLine("mostrar tonteria 3");
                    Console.WriteLine();
                    Console.WriteLine("------opciones-----");
                    Console.WriteLine("0. menu");
                    Console.WriteLine("1. Opcion 1");
                    Console.WriteLine("2. Opcion 2");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine();
                    Console.WriteLine("Ingrese su respuesta:");
                    eleccion = int.Parse(Console.ReadLine());                    
                    Console.Clear();
                    
                }
            }
        }
    }
}
