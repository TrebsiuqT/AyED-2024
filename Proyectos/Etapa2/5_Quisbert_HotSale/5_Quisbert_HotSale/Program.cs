using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Quisbert_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Durante el evento de ventas "Hot Sale", una tienda en línea desea conocer cuál fue el producto más caro y
el más económico que se vendió durante el evento.
El programa solicitará al usuario que ingrese la cantidad de productos vendidos
 durante el Hot Sale.Luego, pedirá al usuario que ingrese el precio de cada producto, uno
 por uno.Una vez ingresados todos los precios, el programa determinará cuál fue
 el precio más alto y cuál fue el precio más bajo.Finalmente, mostrará al usuario
 los precios más alto y más bajo registrados durante el evento.
*/

            //Vector
            Console.Write("Cuantos productos x se vendieron?");
            int x = int.Parse(Console.ReadLine());
            float[] precios = new float[x];

            //Vector2
            string[] productos = new string[x];
            
            for (int i = 0; i < x; i++)
            {
                productos[i] = ("Producto N°"+(i+1));

            }
            
            //Serial
            for (int i = 0; i < x; i++)
            {
                Console.Write("El precio del Producto N°" + (i+1) + " es...");
                precios[i] = float.Parse(Console.ReadLine());
            }

            //lista
            Console.WriteLine("____Lista de Productos____");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(productos[i] + " $" + precios[i]);
            }
            Console.WriteLine("__________________________");
            //Burjeta
            for (int primero = 0; primero < x; primero++)
            {
                for (int segundo = primero; segundo < x; segundo++)
                {
                    if (precios[primero] < precios[segundo])
                    {
                        float aux = precios[primero];
                        precios[primero] = precios[segundo];
                        precios[segundo] = aux;

                        string aux2 = productos[primero];
                        productos[primero] = productos[segundo];
                        productos[segundo] = aux2;
                    }
                }
            }
            Console.WriteLine("_____________Expensive_____________");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(productos[i] + " $" + precios[i]);
            }
            Console.WriteLine("______________Cheap_________________");
        Console.ReadKey();
        }
    }
}
