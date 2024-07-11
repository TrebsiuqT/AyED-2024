using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Quisbert_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*\
             Llenar una matriz de n×m con valores aleatorios entre un rango dado (por ejemplo, 1 a 100).

              \*/
            
            //input y output
            Console.Write("La cantidad de filas:      ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("La cantidad de columnas:     ");
            int m = int.Parse(Console.ReadLine());
            //rango de numeros
            Console.WriteLine("Un rango de numeros para a random [a, b)    ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //crear
            int[,] matriz = new int[n,m];
            //invocar
            Random dado = new Random();
            //asignar
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //n,m
                    matriz[i, j] = dado.Next(a, b);
                }
            }

            Console.WriteLine("Presiona un Tecla");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Matriz");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //si estamos en la ultima columna dejaremos un salto de linea o en su defecto  no
                    if (j == m - 1)
                    {
                        Console.WriteLine(matriz[i,j] + "    |   ");
                    }
                    else
                    {
                        Console.Write(matriz[i, j] + "    |   ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
