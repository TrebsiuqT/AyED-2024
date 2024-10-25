/*
 Crear una matriz Nx3 donde cada fila 
representa un estudiante y cada columna 
contiene información como el nombre, la edad y la calificación
 */

using System.ComponentModel.DataAnnotations.Schema;

Console.Write("(fila) n = ");
int lado = int.Parse(Console.ReadLine());

int vertical = lado * 3;
string[,] matriz = new string[lado, vertical];

for (int fila = 0; fila < lado; fila++)
{
    for (int columna = 0; columna < (vertical); columna++)
    {
        //´para aqeulla esquina
        if (fila == 0 && columna == 0)
        {
            matriz[fila, columna] = "esquina";
        }
        else if (fila == 0 && columna > -1)
        {
            matriz[fila, columna] = "infoss" + columna;
            //para las primer barra del tablero       
        }
        else if(columna == 0 && fila > -1)
        {
            //para la barra vertical del tablero
            matriz[fila, columna] = "alumno" + fila;
        }
        else if (fila != 0 && columna > 0)
        {
            matriz[fila, columna] = "datoos"+columna;
        }
    }
}

//show mee
for (int i = 0; i < lado; i++)
{
    for (int j = 0; j < vertical; j++)
    {
        if (j == vertical - 1)
        {
            //colores para diferenciar 

            Console.Write(matriz[i, j]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------------------->");
            Console.ResetColor();
        }
        else
        {
            Console.Write(matriz[i, j]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("|");
            Console.ResetColor();
        }
    }
}
Console.ReadKey();