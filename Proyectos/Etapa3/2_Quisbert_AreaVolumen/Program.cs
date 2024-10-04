namespace _2_Quisbert_AreaVolumen
{
    internal class Program
    {
        static double CalcularArea(float radio)
        {
            double pi = Math.PI; return (pi * radio * radio);
        }
        static double CalcularVolumen(float radio, float altura)
        {
            double pi = Math.PI; return (pi * radio * radio * altura);
        }
        static void Main(string[] args)
        {
            bool run = true;
            float radio;
            float altura;
            string decision;

            double area;
            double volumen;
            while (run)
            {
                Console.WriteLine("Eliga un opcion\n");
                Console.WriteLine("1. Calcular area circulo y despues su volumen en un cilindrin");
                Console.WriteLine("2. Salir");
                decision = Console.ReadLine().Trim();
                switch (decision)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Radio = ");

                        try
                        {
                            radio = float.Parse(Console.ReadLine().Trim());
                            Console.WriteLine("\n\n...\n");
                            area = CalcularArea(radio);
                            Console.WriteLine("El Area circular = " + area + ", Segun el radio proporcinado.\n\n>Para un cilindro su...\n\n");
                            Console.Write("altura = "); altura = float.Parse(Console.ReadLine().Trim());
                            volumen = CalcularVolumen(radio, altura);
                            Console.WriteLine("\n\n...\n\nEl volumen del cilindro = " + volumen + ". Segun los parametros");
                            Console.Write("Presionar para proceder..."); Console.ReadKey();
                        }
                        catch (SystemException error)
                        {
                            Console.WriteLine("Respuseta invalida - - - > " + error + "\n\nPresionar para proceder");
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case "2":
                        run = false;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
