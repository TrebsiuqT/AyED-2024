namespace _3_Quisbert_PochimonsFuncionales
{
    internal class Program
    {
        static string textocolorin()
        {
            //Console.WriteLine("|Fila\t|Nombre\t\t\t\t|Tipo\t\t|Nivel\t\t|Estado\t|Investigador Asignado\t\t\t|");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("|Fila\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|Nombre\t\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("|Tipo\t\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("|Nivel\t\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|Estado\t");
            Console.ResetColor();
            Console.WriteLine("|Investigador Asignado\t\t\t");
            return ("wazaa");
            //Console.ForegroundColor = ConsoleColor.COLOR;
            //Console.ResetColor();
        }
        static string registrar(string[,] pochidex)
        {
            int indice; //es conveniente declara la variable fuera de try-catch para acceder a esta. y no al reves
            while (true)
            {
                //Paso 1: elegir un espacio en la pochidex
                try
                {
                    Console.Write("Registrar Pochimon en la Pochidex en el espacio N°: ");
                    indice = int.Parse(Console.ReadLine());
                    if (indice < 75 && indice >= 0)
                    {
                        if (pochidex[indice, 0] == null) { break; } // Espacio disponible
                        else { Console.Clear(); Console.WriteLine("( Espacio Ocupado )"); } // Espacio ocupado por otro Pochimon
                    }
                    else { Console.Clear(); Console.WriteLine("( Debe elegir un espacio entre < 0 > y < 74 >)"); }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("( Respuesta invalida )");
                }
            }
            //paso 2: poner los datos del pochimon
            Console.Clear();
            Console.Write("Nombre el Pochimon encontrado\t.....\t");
            string nombre = Console.ReadLine();
            if (nombre == null || nombre == "")
            {
                nombre = "SinNombre";
            }

            string tipo;
            while (true)
            {
                Console.Write("Tipo de Pochimon encontrado (agua/fuego/planta)\t.....\t");
                tipo = Console.ReadLine().ToLower();
                if (tipo == "agua" || tipo == "fuego" || tipo == "planta")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
            //Pedir experiencia del pochimon
            Console.Clear();
            bool convertido = false;
            int experiencia = 0;
            while (convertido == false)
            {
                Console.Clear();
                Console.Write("Nivel de pochimon encontrado\t.....\t");
                string nivel = Console.ReadLine().Trim();
                convertido = int.TryParse(nivel, out experiencia);
            }
            pochidex[indice, 0] = nombre; pochidex[indice, 1] = tipo; pochidex[indice, 2] = experiencia.ToString(); pochidex[indice, 3] = "0"; pochidex[indice, 4] = "0";
            return ("¡Proceso completado!");
        }

        static string mostrar(string[,] pochidex, int indice)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("|" + indice);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t|" + pochidex[indice, 0]);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t|" + pochidex[indice, 1]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\t|" + pochidex[indice, 2]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t|" + pochidex[indice, 3]);
            Console.ResetColor();
            Console.WriteLine("\t|" + pochidex[indice, 4]);
            return ("");
            //Console.WriteLine("| Fila\t| Nombre\t\t\t| Tipo\t| Nivel\t| Estado\t| Investigador Asignado\t\t\t|");
            //Console.WriteLine("|" + indice + "\t|" + pochidex[indice, 0] + "\t\t\t|" + pochidex[indice, 1] +"\t\t|" + pochidex[indice, 2] +"\t|" + pochidex[indice, 3] + "\t|" + pochidex[indice, 4] + "\t|");
        }

        static string asignar(string[,] pochidex)
        {
            bool pass1 = false; bool pass2 = false;
            int fila = 0; string respuesta; int codigo = 0;
            while (pass1 == false)
            {
                textocolorin();
                for (int i = 0; i < 75; i++)
                {
                    if (pochidex[i, 0] != null && pochidex[i, 3] == "0")
                    {
                        mostrar(pochidex, i);
                    }
                }
                Console.WriteLine("\n\n\n----------------------------------------------------------------");
                Console.WriteLine("Seleccione el Pochimon que desea asignar un investigador");
                Console.Write("N° Fila: ");
                respuesta = Console.ReadLine().Trim();
                pass1 = int.TryParse(respuesta, out fila); // guardar_bool = int.tryparse(variable_aconvertir, out respuesta_numero_convertido)
                Console.Clear();
                if (pass1 == true)
                {
                    if (fila > 74 || fila < 0 || pochidex[fila, 0] == null || pochidex[fila, 3] != "0")
                    {
                        pass1 = false;
                        Console.Clear();
                        Console.WriteLine("\nSeleccione solo los Pochimons que se muestran por pantalla");
                    }
                }

            }
            while (pass2 == false)
            {
                Console.Clear();
                Console.WriteLine("Por ultimo, ingrese su codigo numerico investigador");
                respuesta = Console.ReadLine().Trim();
                if (respuesta != "" || respuesta != null)
                {
                    pass2 = int.TryParse(respuesta, out codigo); // (..., out _) el guion sirve para descartar valor
                }

            }
            pochidex[fila, 3] = "1";
            pochidex[fila, 4] = codigo.ToString();
            return ("");
        }

        static string subirexp(string[,] pochidex)
        {
            string respuesta; int fila = 0; bool fila_obtenida = false;
            while (fila_obtenida == false)
            {
                Console.Clear();
                textocolorin();
                for (int i = 0; i < 75; i++)
                {
                    if (pochidex[i, 0] != null)
                    {
                        mostrar(pochidex, i);
                    }
                }
                Console.Write("\n\nEliga un Pochimon de la fila para subir exp: ");
                respuesta = Console.ReadLine().Trim();
                if (respuesta != null || respuesta != "")
                {
                    fila_obtenida = int.TryParse(respuesta, out fila);
                    if (fila_obtenida == true && fila > 75 || fila < 0 || pochidex[fila, 0] == null)
                    {
                        fila_obtenida = false;
                    }
                }

            }
            Random dado = new Random();
            int entero;
            int.TryParse(pochidex[fila, 2], out entero);
            int suerte = dado.Next(1, 4);
            pochidex[fila, 2] = (entero + suerte).ToString();

            Console.Write("\nProceso completado! " + entero + " + " + suerte + " = " + pochidex[fila, 2] + "\n\n");
            return ("");
        }

        static string investigado(string[,] pochidex)
        {
            bool pass = false; int fila = 0; string respuesta;
            while (pass == false)
            {
                Console.Clear();
                textocolorin();
                for (int i = 0; i < 75; i++)
                {
                    if (pochidex[i, 0] != null && pochidex[i, 3] == "1")
                    {
                        mostrar(pochidex, i);
                    }
                }
                Console.Write("\n\nSelecciona la fila del pochimon que desea marcar como INVESTIGADO:");
                respuesta = Console.ReadLine().Trim();
                pass = int.TryParse(respuesta, out fila);
                if (pass)
                {
                    if (fila < 75 && fila >= 0 && pochidex[fila, 0] != null && pochidex[fila, 3] == "1")
                    {
                        //ese pochi debe existir y debe ser "1"
                    }
                    else
                    {
                        pass = false;
                    }
                }
            }
            pochidex[fila, 3] = "2";
            Console.WriteLine("\n. . .");
            Console.Write("\nProceso completado!\n");
            return ("");
        }
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------------------------------

            //Pochidex Matrix
            string[,] pochidex = new string[75, 5];
            //pochifuncion

            //by chatgiti
            // Cambiar el color del texto a verde
            //Console.ForegroundColor = ConsoleColor.COLOR;
            //Console.ResetColor();

            int pochimons_encontrados = 0;
            //while
            bool run = true; string opcion_deseada;
            while (run)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Menú Principal - Centro de Investigación de Pochimons");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Pochimones Encontrados: " + pochimons_encontrados + "/75");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar Investigador a Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostrar Informacion de Pochimons");
                Console.WriteLine("6. Buscar Pochimons por Tipo");
                Console.WriteLine("7. Mostrar Pochimons por Investigador");
                Console.WriteLine("8. Mostrar Pochimons Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Ingrese la opcion deseada: ");
                opcion_deseada = Console.ReadLine().Trim();
                switch (opcion_deseada)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n" + registrar(pochidex) + "\n");
                        pochimons_encontrados++;
                        break;
                    case "2":
                        Console.Clear();
                        asignar(pochidex);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        subirexp(pochidex);
                        break;
                    case "4":
                        Console.Clear();
                        investigado(pochidex);
                        break;
                    case "5":
                        Console.Clear(); textocolorin();
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, 0] != null)
                            {
                                mostrar(pochidex, i);
                            }
                        }
                        Console.Write("\nPresionar para proceder\n\n");
                        Console.ReadKey();
                        break;
                    case "6":
                        string respuesta2;
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Ingrese el tipo (agua/fuego/planta) de pochimon para mostrar: ");
                            respuesta2 = (Console.ReadLine().Trim()).ToLower();
                            if (respuesta2 == "fuego" || respuesta2 == "agua" || respuesta2 == "planta")
                            {
                                break;
                            }
                        }
                        textocolorin();
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, 0] != null && pochidex[i, 1] == respuesta2)
                            {
                                mostrar(pochidex, i);
                            }
                        }
                        Console.Write("\nPresionar para proceder\n\n");
                        Console.ReadKey();
                        break;
                    case "7":
                        string respuesta3 = ""; bool passing = false;
                        while (passing == false)
                        {
                            Console.Clear();
                            Console.Write("Escriba el codigo de investigador: ");
                            respuesta3 = Console.ReadLine().Trim();
                            passing = int.TryParse(respuesta3, out _);
                        }
                        textocolorin();
                        for (int i = 0; i < 75; i++)
                        {
                            if (pochidex[i, 0] != null && pochidex[i, 4] == respuesta3)
                            {
                                mostrar(pochidex, i);
                            }
                        }
                        Console.Write("\nPresionar para proceder\n\n");
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        textocolorin(); string exp; int exp_numerico;
                        for (int i = 0; i < 75; i++)
                        {
                            exp = pochidex[i, 2];
                            int.TryParse(exp, out exp_numerico);
                            if (pochidex[i, 0] != null && exp_numerico > 30)
                            {
                                mostrar(pochidex, i);
                            }
                        }
                        Console.Write("\nPresionar para proceder\n\n");
                        Console.ReadKey();
                        break;
                    case "9":
                        run = false; break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
