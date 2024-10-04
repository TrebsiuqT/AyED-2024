namespace _1_Quisbert_SistemaDeConversiones
{
    internal class Program
    {
        static string conversion_binario(int numero_decimal)
        {
            string binario = "1";
            int bit;
            if (numero_decimal == 0)
            {
                binario = "0";
            }
            while (numero_decimal / 2 > 0) //Solo numero numero positivo.
            {
                bit = numero_decimal % 2; //obtener el resto
                numero_decimal = numero_decimal / 2; //el decimal se va cortando
                binario += bit.ToString(); //agregamos bit

            }
            return (binario);
        }
        static string conversion_decimal(int numero_binario)
        {
            string cadena = numero_binario.ToString();
            int caracteres = cadena.Length;
            double decimal_resultado = 0;

            for (int i = 0; i < caracteres; i++)
            {
                char digito_char = cadena[(caracteres - 1) - i];
                int digito_int = digito_char - '0'; // segun valores ASCII, se obtiene un numero

                if (digito_int != 1 && digito_int != 0)
                {
                    return ("Existe un bit que no es > 1 < ni > 0 <"); //Retornar y terminar la funcion
                }
                decimal_resultado += digito_int * Math.Pow(2, i);
            }
            return (decimal_resultado.ToString());
        }
        static void Main(string[] args)
        {
            bool run = true;
            string respuesta;
            int parametro_decimal;
            string retorno_binario;

            int parametro_binario;
            string retorno_decimal; //como mensaje o como valor
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Eliga un opcion de conversion");
                Console.WriteLine("1. A decimal");
                Console.WriteLine("2. A binario");
                Console.WriteLine("3. Salir de aqui");
                respuesta = Console.ReadLine().Trim();
                switch (respuesta)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Convertirlo --> ");
                        try
                        {
                            parametro_binario = int.Parse(Console.ReadLine().Trim());
                            Console.Clear();
                            retorno_decimal = conversion_decimal(parametro_binario);
                            Console.WriteLine(parametro_binario + " -> " + retorno_decimal);
                        }
                        catch (System.Exception error)
                        {
                            Console.Clear();
                            Console.WriteLine(error);
                        }
                        Console.WriteLine("\n Presionar para continuar"); Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Convertirlo --> ");
                        try
                        {
                            parametro_decimal = int.Parse(Console.ReadLine().Trim());
                            Console.Clear();
                            retorno_binario = conversion_binario(parametro_decimal);
                            Console.WriteLine(parametro_decimal + " -> " + retorno_binario);
                        }
                        catch (System.Exception error)
                        {
                            Console.Clear();
                            Console.WriteLine(error);
                        }
                        Console.WriteLine("\n Presionar para continuar"); Console.ReadKey();
                        break;
                    case "3":
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t<Intentar de nuevo>");
                        break;
                }
            }
        }
    }
}
