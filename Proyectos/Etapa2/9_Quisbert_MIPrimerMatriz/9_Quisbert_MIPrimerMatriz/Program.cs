using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Quisbert_MIPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por pantalla

               n y m son datos que ingresa el usuario
             */

            /* porobnad porob probando
            int[,] matriz = new int[3, 5];
            matriz[0, 0] = 323;

            Console.WriteLine(matriz[0,0]);
            Console.ReadKey();
            */

            Console.Write("La fila de la matriz es      ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("La columna de la matriz es   ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Show");
            Console.WriteLine("");

            //f (daclara, mientras, pasos)

            //Filas
            for (int i = 0; i < n; i++)
            {                
                //columna
                for (int h = 0; h < m; h++)
                {
                    //para cada lugar
                    matriz[i, h] = 0;
                }       
            }

            for (int i = 0; i < n; i++)
            {
                //columna
                
                for (int h = 0; h < m; h++)
                {
                    //para cada lugar mostrar
                    if (h == (m-1))
                    {
                        Console.WriteLine(matriz[i, h]+" | ");
                        Console.WriteLine("---------------------------------------------------->");
                    }
                    else
                    { Console.Write(matriz[i, h] + " | ");  }
                }
            }
            Console.ReadKey();

        }
    }
}
