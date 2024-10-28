namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int rta;
            int save_in;
            int assing;
            int change_ex;
            string[,] matriz = new string[75, 5];
            int[] vector_exp = new int[75];
            int code;
            Random dado = new Random();
            int aux;
            int change_2;
            string tipo;
            string codigo; int picada;
            int cantidad = 0;
            //main
            while (run)
            {
                //Output text
                Console.Write("Pochidex | pochimons " + cantidad + "/74 \n");
                Console.Write("---------------------------------------------->\n");
                Console.Write("1.Registrar Pochimon\n");
                Console.Write("2.Asignar investigador\n");
                Console.Write("3.Actualizar Nivel de Pochimon\n");
                Console.Write("4.Marcar Pochimon como Investigado\n");
                Console.Write("5.Mostrar Informacion de Pochimons\n");
                Console.Write("6.Buscar Pochimons por Tipo\n");
                Console.Write("7.Mostrar Pochimons por Investigador\n");
                Console.Write("8.Mostrar Pochimons Picados\n");
                Console.Write("9.Salir\n");
                Console.Write("---------------------------------------------->\n\n");

                //Valor entrada forzada
                Console.Write("Input: ");
                rta = int.Parse(Console.ReadLine().Trim()); //solo int's
                while (rta > 9 || rta < 1)
                {
                    Console.Clear();
                    Console.Write("Pochidex | pochimons " + cantidad + "/74 \n");
                    Console.Write("---------------------------------------------->\n");
                    Console.Write("1.Registrar Pochimon\n");
                    Console.Write("2.Asignar investigador\n");
                    Console.Write("3.Actualizar Nivel de Pochimon\n");
                    Console.Write("4.Marcar Pochimon como Investigado\n");
                    Console.Write("5.Mostrar Informacion de Pochimons\n");
                    Console.Write("6.Buscar Pochimons por Tipo\n");
                    Console.Write("7.Mostrar Pochimons por Investigador\n");
                    Console.Write("8.Mostrar Pochimons Picados\n");
                    Console.Write("9.Salir\n");
                    Console.Write("---------------------------------------------->\n\n");
                    Console.Write("Input: ");
                    rta = int.Parse(Console.ReadLine().Trim());
                }

                //switch
                switch (rta)
                {
                    case 1:
                        Console.Clear();
                        while (true)
                        {
                            Console.Write("Guardar datos en el espacio N° <0 a 74>:");
                            save_in = int.Parse(Console.ReadLine());
                            while (save_in < 0 || save_in > 74 || matriz[save_in, 0] != null) //si existe obj
                            {
                                Console.Clear();
                                if (save_in < 0 || save_in > 74)
                                {
                                    Console.Write("N° espacio excedido. Guardar datos en el espacio N°:");
                                }
                                else
                                {
                                    Console.Write("N° espacio OCUPADO. Guardar datos en el espacio N°:");
                                }
                                save_in = int.Parse(Console.ReadLine());
                            }
                            Console.Clear();
                            Console.Write("Nombre: "); matriz[save_in, 0] = Console.ReadLine();
                            Console.Write("Tipo(fuego,agua,tierra): "); matriz[save_in, 1] = Console.ReadLine();
                            while (matriz[save_in, 1].ToLower() != "agua" && matriz[save_in, 1].ToLower() != "fuego" && matriz[save_in, 1].ToLower() != "planta")
                            {
                                Console.Write("(no valido)"); matriz[save_in, 1] = Console.ReadLine();
                            }
                            Console.Write("Nivel: "); vector_exp[save_in] = int.Parse(Console.ReadLine());
                            matriz[save_in, 2] = vector_exp[save_in].ToString(); //convert string
                            matriz[save_in, 3] = "0";
                            matriz[save_in, 4] = "0";
                            Console.Clear(); Console.WriteLine("Pochimon guardado");
                            cantidad += 1;
                            break;
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Seleccione un Pochimon disponible por medio de ID Pochimon o FILA.\n");
                            Console.Write("ID\t"); Console.Write("Nombre\t"); Console.Write("Tipo\t"); Console.WriteLine("Nivel\t");
                            Console.Write("-----------------------------------------------------------------------------------------\n");
                            for (int ID = 0; ID < 75; ID++)
                            {
                                if (matriz[ID, 0] != null && matriz[ID, 3] == "0") //que exista y que este estado 0
                                {
                                    Console.Write(ID + "\t|"); Console.Write(matriz[ID, 0] + "\t|"); Console.Write(matriz[ID, 1] + "\t|"); Console.WriteLine(matriz[ID, 2] + "\t|");
                                }
                            }
                            assing = int.Parse(Console.ReadLine().Trim());
                            if (assing >= 0 && assing <= 74 && matriz[assing, 0] != null && matriz[assing, 3] == "0") //swasa
                            {
                                break;
                            }
                            else
                            {
                                //lose;
                            }
                        }
                        Console.WriteLine("Ingrese el codigo de investigador");
                        matriz[assing, 3] = "1";
                        code = int.Parse(Console.ReadLine());
                        matriz[assing, 4] = code.ToString();
                        break;
                    case 3:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el ID o N° de FILA de pochimon");
                            Console.Write("ID\t| Nombre\t| Nivel\n");
                            Console.WriteLine("---------------------------------------------");
                            for (int id = 0; id < 75; id++)
                            {
                                if (matriz[id, 0] != null) //si existe
                                {
                                    Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t|" + matriz[id, 2]);
                                }
                            }
                            Console.WriteLine();
                            Console.Write("ID o Fila de pochimon para cambiar la exp: ");
                            change_ex = int.Parse(Console.ReadLine());
                            if (change_ex >= 0 && change_ex <= 74 && matriz[change_ex, 0] != null)
                            {
                                aux = int.Parse(matriz[change_ex, 2]) + dado.Next(1, 3);
                                matriz[change_ex, 2] = aux.ToString();
                                Console.Write("Nueva exp para pochimon: " + matriz[change_ex, 2] + "");
                                break;
                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione el ID o FIla de pochimon para cambiar como a Investigado (2) de investigando (1)");
                            Console.WriteLine("ID\t| Nombre\t| Tipo\t| Nivel\t| Estado\t| C# investigador");
                            Console.WriteLine("-------------------------------------------------------------------");
                            for (int id = 0; id < 75; id++)
                            {
                                if (matriz[id, 0] != null && matriz[id, 3] == "1")
                                {
                                    Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t|" + matriz[id, 1] + "\t|" + matriz[id, 2] + "\t|" + matriz[id, 3] + "\t|" + matriz[id, 4]);
                                }
                            }
                            Console.WriteLine();
                            Console.Write("you input: ");
                            change_2 = int.Parse(Console.ReadLine());
                            if (change_2 >= 0 && change_2 <= 74 && matriz[change_2, 0] != null && matriz[change_2, 3] == "1")
                            {
                                matriz[change_2, 3] = "2";
                                Console.Write(" LISTO ");
                                break;
                            }
                        }
                        break;
                    case 5:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("iD\t | Nombre\t | Tipo\t | Nivel\t | C# de investigador");
                            Console.WriteLine("--------------------------------------------------------------");
                            for (int id = 0; id < 75; id++)
                            {
                                if (matriz[id, 0] != null) //si existe
                                {
                                    Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t| " + matriz[id, 1] + "\t| " + matriz[id, 2] + "\t|" + matriz[id, 3] + "\t|" + matriz[id, 4]);
                                }

                            }
                            Console.Write("Presione volver");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        break;
                    case 6:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Escriba el tipo del pochimon correctamente (fuego, agua, planta): ");
                            tipo = Console.ReadLine();

                            if (tipo.ToLower() != "agua" && tipo.ToLower() != "planta" && tipo.ToLower() != "fuego") //si no eres
                            {
                                //mal
                            }
                            else { break; }

                        }
                        Console.WriteLine("\nID\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|C# investigador");
                        Console.WriteLine("--------------------------------------------------");
                        for (int id = 0; id < 75; id++)
                        {
                            if (matriz[id, 0] != null && matriz[id, 1].ToLower() == tipo.ToLower())
                            {
                                Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t|" + matriz[id, 1] + "\t|" + matriz[id, 2] + "\t|" + matriz[id, 3] + "\t|" + matriz[id, 4]);
                            }

                        }
                        Console.WriteLine("Presionar para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el C# existente de investigador: ");
                            codigo = Console.ReadLine();
                            Console.WriteLine("\nID\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|C# investigador");
                            Console.WriteLine("--------------------------------------------------");
                            for (int id = 0; id < 75; id++)
                            {
                                if (matriz[id, 0] != null && matriz[id, 4] == codigo)
                                {
                                    Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t|" + matriz[id, 1] + "\t|" + matriz[id, 2] + "\t|" + matriz[id, 3] + "\t|" + matriz[id, 4]);
                                }
                            }
                            break;
                        }
                        Console.Write("Presionar para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Pochimons con exp o nivel >>> 30");
                            Console.WriteLine("\nID\t|Nombre\t|Tipo\t|Nivel\t|Estado\t|C# investigador");
                            Console.WriteLine("--------------------------------------------------");
                            for (int id = 0; id < 75; id++)
                            {
                                if (matriz[id, 0] != null)
                                {
                                    picada = int.Parse(matriz[id, 2]);
                                    if (picada > 30)
                                    {
                                        Console.WriteLine(id + "\t|" + matriz[id, 0] + "\t|" + matriz[id, 1] + "\t|" + matriz[id, 2] + "\t|" + matriz[id, 3] + "\t|" + matriz[id, 4]);
                                    }
                                }

                            }
                            break;
                        }
                        Console.Write("Presionar para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        run = false;
                        break;
                }
            }
            Console.Write("hasta la vista baby. Presionar para salir");
            Console.ReadKey();
        }
    }
}
