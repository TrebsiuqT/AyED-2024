using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Quisbert_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sumar dos matrices de igual tamaño nxn*/
            Console.Write("Dos matrices cuadradas con lado =    ");
            int lado = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[lado, lado];
            int[,] matrizB = new int[lado, lado];
            int[,] matrizC = new int[lado, lado];

            Random dado = new Random();

            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    matrizA[i, j] = dado.Next(0, 2);
                    matrizB[i, j] = dado.Next(0, 2);
                }
            }

            Console.WriteLine("Para proceder presionar una tecla");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Show matriz A");
            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    if ( j == lado-1)
                    {
                        Console.WriteLine(matrizA[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(matrizA[i, j] + " | ");
                    }
                }
            }


            Console.WriteLine("Show matriz B");
            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    if (j == lado - 1)
                    {
                        Console.WriteLine(matrizB[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(matrizB[i, j] + " | ");
                    }
                }
            }

            Console.WriteLine("A + B = C");

            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Show Matriz C");

            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    if (j == lado - 1)
                    {
                        Console.WriteLine(matrizC[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(matrizC[i, j] + " | ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
