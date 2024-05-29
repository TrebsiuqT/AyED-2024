using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Quisbert_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Después de unas largas vacaciones llenas de aventuras, Phineas y Ferb regresan a la escuela. 
            Sin embargo, como no estudiaron durante las vacaciones, necesitan un sistema que les ayude a 
            determinar si podrán aprobar la materia.
            El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos 
            (TPs) y exámenes que tienen en la materia. Luego, deben ingresar las notas de cada TP y examen.
            Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:


            El promedio de las notas de los exámenes debe ser mayor o igual a 6.
            Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
            El sistema debe calcular el promedio de los exámenes y verificar si se cumplen 
            las condiciones para aprobar la materia. Finalmente, debe mostrar en pantalla un 
            mensaje indicando si Phineas y Ferb pueden aprobar la materia o no.
            Permitir al usuario especificar la cantidad de TPs y exámenes.
            Permitir al usuario ingresar las notas de cada TP y examen.
            Calcular el promedio de las notas de los exámenes.
            Verificar si se cumplen las condiciones para aprobar la materia.
            Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia.  
            
             */


            //Preparando
            Console.WriteLine("Ingrese la cantidad de TPs");
            int tps = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de examenes");
            int examenes = int.Parse(Console.ReadLine());

            float[] notasTps = new float[tps];
            float[] notasExamenes = new float[examenes];

            //Input TPs
            for (int indice = 0; indice < tps; indice++)
            {
                Console.WriteLine("Ingrese la notas del TP N°" + (indice + 1));
                notasTps[indice] = float.Parse(Console.ReadLine());
            }
            //Input Examenes
            for (int indice = 0; indice < examenes; indice++)
            {
                Console.WriteLine("Ingrese la notas del examen N°" + (indice + 1));
                notasExamenes[indice] = float.Parse(Console.ReadLine());
            }
            //Calculando promedio
            float notastotalexamen = 0;
            bool condicionuno = false;
            for (int indice = 0; indice < examenes; indice++)
            {
                notastotalexamen += notasExamenes[indice];
            }
            float promedioexamen = (notastotalexamen / examenes);
            if (promedioexamen >= 6)
            {
                condicionuno = true;
            }
            //Cantidad de TP con 6
            float aprobadotp = 0;
            bool porcentaje = false;
            for (int indice = 0; indice < tps; indice++)
            {
                if (notasTps[indice] >= 6)
                {
                    aprobadotp++;
                }
            }
            //determinamos si 75
            if (aprobadotp >= (examenes * 0.75))
            { porcentaje = true; }

            //Stats
            Console.WriteLine("_____________RESULTADOS_______________");
            Console.WriteLine("Cantidad de TPs: " + tps + " | Cantidad de TP > 6: " + aprobadotp);
            Console.WriteLine("Cantidad de Examenes: " + examenes + " | Promedio de los examenes: " + promedioexamen);
            Console.WriteLine("Se cumplio el 75%???:" + porcentaje);
            Console.WriteLine("El promedio de los examenes > 6??" + condicionuno);

            Console.WriteLine("Registro TP:");
            for (int i = 0; i < tps; i++)
            {
                Console.WriteLine("TP n°"+(i+1)+": ... "+notasTps[i]);
            }
            Console.WriteLine("Registro Examenes:");
            for (int i = 0; i < examenes; i++)
            {
                Console.WriteLine("Examen n°" + (i + 1) + ": ... " + notasExamenes[i]);
            }
            if (condicionuno == true && porcentaje == true)
            {
                Console.WriteLine("PUEDEN APROBAR LA MATERIA");
            }
            else { Console.WriteLine("NO PUEDEN APROBAR LA MATERIA"); }
            Console.WriteLine("______________________________________");
            Console.ReadKey();
        }
    }
}
