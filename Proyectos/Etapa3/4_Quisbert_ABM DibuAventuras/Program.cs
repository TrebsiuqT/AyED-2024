﻿using System.ComponentModel;
using System.Net.Http.Headers;

namespace _4_Quisbert_ABM_DibuAventuras
{
    internal class Program
    {
        static string nuevo_personaje(object[,] matriz)
        {
            Console.Clear();
            bool ok = false; int indice = 0; while (ok == false)
            {
                Console.Write("Eliga el N° Slot (0-19): ");
                string str_indice = Console.ReadLine();
                ok = int.TryParse(str_indice, out indice);
                if (ok == true)
                {
                    if (indice < 19 && indice >= 0 && matriz[indice, 0] == null)
                    {
                        ok = true;
                    }
                    else
                    {
                        ok = false;
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                }
            }

            Console.Write("\nNombre del personaje: ");
            string nombre = Console.ReadLine().Trim();
            Console.Write("\nNombre de la serie del Personaje: ");
            string serie = Console.ReadLine().Trim();

            int fuerza = 0; bool pass = false; while (pass == false)
            {
                Console.Write("\nCantidad de fuerza: ");
                string str_fuerza = Console.ReadLine().Trim();
                pass = int.TryParse(str_fuerza, out fuerza);
                if (pass == false)
                { Console.Clear(); }
            }

            int defensa = 0; pass = false; while (pass == false)
            {
                Console.Write("\nCantidad de defensa: ");
                string str_defensa = Console.ReadLine().Trim();
                pass = int.TryParse(str_defensa, out defensa);
                if (pass == false)
                { Console.Clear(); }
            }

            bool es_heroe = false; pass = false; while (pass == false)
            {
                Console.Write("\n¿Es un heroe, >No< o >Si<? ");
                string str_es_heroe = (Console.ReadLine()).ToLower().Trim();
                if (str_es_heroe == "si" || str_es_heroe == "no")
                {
                    pass = true;
                    if (str_es_heroe == "si")
                    { es_heroe = true; }
                    else { es_heroe = false; }
                }
                else
                {
                    Console.Clear();
                }
            }
            matriz[indice, 0] = nombre;
            matriz[indice, 1] = serie;
            matriz[indice, 2] = fuerza;
            matriz[indice, 3] = defensa;
            matriz[indice, 4] = es_heroe;
            Console.Clear();
            return ("\n\nExito\n\n");
        }

        static string colorin()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Nombre\t\t|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Serie\t|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Fuerza\t|");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Defensa\t|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Heroe\t|");
            Console.ResetColor();
            return ("");
        }

        static string mostrar(object[,] matriz, int i)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(matriz[i, 0] + "\t|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(matriz[i, 1] + "\t |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(matriz[i, 2] + "\t |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(matriz[i, 3] + "\t |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(matriz[i, 4] + "\t");
            Console.ResetColor();
            return ("");
        }

        static string consultar_personaje(object[,] matriz)
        {
            Console.Write("Buscar el personaje por su nombre: ");
            string respuesta = Console.ReadLine().Trim();

            Console.Clear(); colorin();
            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 0] != null && matriz[i, 0].ToString() == respuesta)
                {
                    mostrar(matriz, i);
                }
            }
            Console.Write("\nPresionar para proceder\n");
            Console.ReadKey(); return ("");
        }

        static string modificar_personaje(object[,] matriz)
        {
            bool pass = false; int indice = 0;
            while (pass == false)
            {
                Console.Clear(); colorin();
                //Type tipoDato = matriz[0, 3].GetType();
                //Console.WriteLine(tipoDato);
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 0] != null)
                    {
                        mostrar(matriz, i);
                    }
                }

                Console.Write("\nNombre del Personaje a modificar : ");
                string respuesta = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 0] != null && matriz[i, 0].ToString() == respuesta) //problema no considerado: SI EXISTEN DOS PERSONAJES CON EL MISMO NOMBRE
                    {
                        indice = i;
                        pass = true;
                    }
                    //Cuando se usa == para comparar un object con un string, (esta es una matriz objecto)
                    //el compilador no puede garantizar que o sea un string,
                    //por lo que no puede realizar la comparación directa y lanza el error CS0252. POR ESO TENGO QUE PONER .ToString apesar de que matriz[i,0] sea string
                }
            }
            int nueva_fuerza = 0; int nueva_defensa = 0;
            bool pass2 = false; bool pass3 = false;
            while (pass2 == false)
            {
                Console.Clear();
                Console.Write("Fuerza del personaje: ");
                string nueva_string_fuerza = Console.ReadLine().Trim();
                pass2 = int.TryParse(nueva_string_fuerza, out nueva_fuerza);
            }
            while (pass3 == false)
            {
                Console.Clear();
                Console.Write("Defensa del personaje: ");
                string nueva_string_defensa = Console.ReadLine().Trim();
                pass3 = int.TryParse(nueva_string_defensa, out nueva_defensa);
            }

            matriz[indice, 2] = nueva_fuerza; matriz[indice, 3] = nueva_defensa;
            return ("");
        }

        static string eliminar_personaje(object[,] matriz)
        {
            int indice = 0; bool pass = false;
            while (pass == false)
            {
                Console.Clear(); colorin();
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 0] != null)
                    {
                        mostrar(matriz, i);
                    }
                }
                Console.Write("\nNombre del Personaje a borrar : ");
                string respuesta = Console.ReadLine().Trim();
                for (int i = 0; i < 20; i++)
                {
                    if (matriz[i, 0] != null && matriz[i, 0].ToString() == respuesta) //problema no considerado: SI EXISTEN DOS PERSONAJES CON EL MISMO NOMBRE
                    {
                        indice = i;
                        pass = true;
                    }
                    //Cuando se usa == para comparar un object con un string, (esta es una matriz objecto)
                    //el compilador no puede garantizar que o sea un string,
                    //por lo que no puede realizar la comparación directa y lanza el error CS0252. POR ESO TENGO QUE PONER .ToString apesar de que matriz[i,0] sea string
                }
            }

            //borar datos
            for (int lugar = 0; lugar < 5; lugar++)
            {
                matriz[indice, lugar] = null;
            }
            return ("");
        }

        static string ordenar_alfabeticamente(object[,] matriz)
        {
            List<string> nombres = new List<string>();
            // Cargar los nombres en una lista
            for (int i = 0; i < 20; i++)
            {
                if (matriz[i, 0] != null)
                {
                    nombres.Add(matriz[i, 0].ToString());
                }
            }
            // Ordenar nombres en Lista
            nombres.Sort(); int x = 0;

            foreach (string nombre in nombres)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (matriz[y, 0] != null)
                    {
                        if (nombre == matriz[y, 0].ToString())
                        {
                            // Cambiar datos de fila "y" por fila "x"
                            List<object> list_aux = new List<object>();
                            for (int i = 0; i < 5; i++)
                            {
                                list_aux.Add(matriz[y, i]);
                            }

                            for (int i = 0; i < 5; i++)
                            {
                                matriz[y, i] = matriz[x, i];
                            }

                            for (int i = 0; i < 5; i++)
                            {
                                matriz[x, i] = list_aux[i];
                            }
                        }
                    }
                }
                x++;
            }
            return ("");
        }
        // Funcion Principal
        static void Main(string[] args)
        {
            object[,] matriz = new object[20, 5];
            bool run = true; string respuesta;

            while (run)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Nuevo Personaje");
                Console.WriteLine("2. Consultar Personaje");
                Console.WriteLine("3. Modificar Personaje");
                Console.WriteLine("4. Eliminar Personaje");
                Console.WriteLine("5. Mostrar todos los personajes");
                Console.WriteLine("--------------------------------------");
                Console.Write("\nLeerInput:");
                respuesta = Console.ReadLine().Trim();
                switch (respuesta)
                {
                    case "1":
                        Console.Write(nuevo_personaje(matriz));
                        break;
                    case "2":
                        Console.Clear();
                        consultar_personaje(matriz);
                        break;
                    case "3":
                        modificar_personaje(matriz);
                        break;
                    case "4":
                        Console.Clear();
                        eliminar_personaje(matriz);
                        break;
                    case "5":
                        Console.Clear();
                        ordenar_alfabeticamente(matriz);

                        colorin();
                        for (int i = 0; i < 20; i++)
                        {
                            if (matriz[i, 0] != null)
                            {
                                mostrar(matriz, i);
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
