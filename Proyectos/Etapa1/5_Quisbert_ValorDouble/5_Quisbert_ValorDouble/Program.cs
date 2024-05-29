using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Quisbert_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Escriba un programa en C# que solicite el ancho (x) y la altura (y) 
                de un rectángulo y calcule el perímetro, el área y la diagonal.
                Perímetro= suma de los cuatro lados.
                Área= base x altura.
                Diagonal= Teorema de Pitágoras.
            */
            Console.WriteLine("Ingrese una altura para triangulo ");
            double alto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un ancho para un triangulo");
            double ancho = double.Parse(Console.ReadLine());
            double hipotenusa = Math.Sqrt(Math.Pow(alto, 2) + Math.Pow(ancho, 2));
            double perimetro = (alto + ancho + hipotenusa);
            double area = (ancho * alto);
            Console.WriteLine("Perimetro = " + perimetro);
            Console.WriteLine("Hipotenusa = " + hipotenusa);
            Console.WriteLine("Area = " + area);
            Console.ReadKey();
        }
    }
}
