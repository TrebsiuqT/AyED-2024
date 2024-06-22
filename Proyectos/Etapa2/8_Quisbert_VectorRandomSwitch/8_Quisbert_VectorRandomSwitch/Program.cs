using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Quisbert_VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //natural
            Console.Write("Ingrese un numero natural -> ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            //Dados
            Random x = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = x.Next(1, 999);
            }

            //print vector, usu input number == vector if: index show o else :nothing
            //se ordena e vector ¿¿ end console


            //bucle

            bool bucle = true;

            while (bucle)
            {
                Console.WriteLine("Eliga un opcion coherente ");
                Console.WriteLine("(1) Imprimir el vactor");
                Console.WriteLine("(2) Hallar un numero en el vector");
                Console.WriteLine("(3) Ordenar de forma ascendente");
                Console.WriteLine("(4) Ordenar de forma descendente");
                Console.WriteLine("(5) Salir del programa");
                string opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":

                        Console.WriteLine("--------Vector--------");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Elemento N" + (i + 1) + " -> " + vector[i] + " | Index = " + i);
                        }
                        Console.WriteLine("----------------------");
                        Console.WriteLine("");
                        break;

                    case "2":

                        //--------------Finding------------------
                        Console.WriteLine("Ingrese un valor para indentificarlo... -> ");
                        int z = int.Parse(Console.ReadLine());
                        bool output = false;

                        for (int i = 0; i < n; i++)
                        {
                            if (z == vector[i])
                            {
                                Console.WriteLine("Se encontro " + z + " en la posicion " + i);
                                output = true;
                            }
                        }

                        //respuesta unica
                        if (output == false)
                        { Console.WriteLine("[No se encontro " + z + " en el vector]"); }
                        Console.ReadKey();

                        break;
                    case "3":

                        //--------------Ordenar de Ascendiente--------------
                        for (int i = 0; i < n; i++)
                        {
                            for (int y = i; y < n; y++)
                            {
                                if (vector[i] < vector[y])
                                {
                                    int aux = vector[i];
                                    vector[i] = vector[y];
                                    vector[y] = aux;
                                }
                            }
                        }

                        Console.WriteLine("--------Vector ORDENADO decendientemente--------");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Elemento N" + (i + 1) + " -> " + vector[i] + " | Index = " + i);
                        }
                        Console.WriteLine("----------------------");
                        Console.WriteLine("");

                        break;
                    case "4":

                        //--------------ordenar decendiente--------------

                        for (int i = 0; i < n; i++)
                        {
                            for (int y = i; y < n; y++)
                            {
                                if (vector[i] > vector[y])
                                {
                                    int aux = vector[i];
                                    vector[i] = vector[y];
                                    vector[y] = aux;
                                }
                            }
                        }

                        Console.WriteLine("--------Vector ORDENADO ascendientemente--------");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Elemento N" + (i + 1) + " -> " + vector[i] + " | Index = " + i);
                        }
                        Console.WriteLine("----------------------");

                        break;
                    case "5":

                        bucle = false;

                        break;
                    default:
                        Console.WriteLine("---------------[Intentelo de nuevo]-----------");
                        break;
                }
            }
            

            /*
            //-----------print------------

            Console.WriteLine("--------Vector--------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Elemento N" + (i + 1) + " -> " + vector[i] + " | Index = " + i);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            */

            Console.ReadKey();
        }
    }
}
