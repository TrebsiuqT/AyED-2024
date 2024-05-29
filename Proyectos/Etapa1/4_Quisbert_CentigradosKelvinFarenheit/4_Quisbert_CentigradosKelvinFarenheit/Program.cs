using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Quisbert_CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             La escala Celsius es centígrada, 100 divisiones 
             separan el punto de congelación del punto de ebullición
             del agua. En la escala Fahrenheit de los 
             anglosajones, estos dos puntos están separados 
             por 180 grados. La escala de Kelvin es una escala 
             absoluta utilizada en ciencias.
             Cree un programa en C# para convertir de grados 
             centígrados a Kelvin y Fahrenheit. 
             Solicite al usuario la cantidad de grados 
             centígrados para convertirlos usando 
             las siguientes tablas de conversión:
             kelvin = celsius + 273
             fahrenheit = celsius x 18/10 + 32
             */
            Console.WriteLine("Ingrese una cantidad de grados");
            double celcius = double.Parse(Console.ReadLine());
            double kelvin = (celcius + 273);
            double fahrenheit = (celcius * 0.8 + 32);
            Console.WriteLine("Centigrados = " + celcius + " Kelvin = " + kelvin + " Fahrenheit = " + fahrenheit);
            Console.ReadKey();
        }
    }
}
