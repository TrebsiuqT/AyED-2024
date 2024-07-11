/*Rotar una matriz cuadrada n×n 90 grados en sentido horario.*/

Console.Write("Una matriz cuadrada de lado -> ");
int lado = int.Parse(Console.ReadLine());
Console.Write("Rango de numeros ->>");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int[,] matriz = new int[lado, lado];

Random dado = new Random();

for (int i = 0; i < lado; i++)
{
    for (int j = 0; j < lado; j++)
    {
        matriz[i, j] = dado.Next(a, b);
    }
}

Console.WriteLine("Proceder Press");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Show Matriz");
for (int i = 0; i < lado; i++)
{
    for (int j = 0; j < lado; j++)
    {
        if (j == lado - 1)
        {
            Console.WriteLine(matriz[i, j] + " | ");
        }
        else
        {
            Console.Write(matriz[i, j] + " | ");
        }
    }
}
//voltear.

Console.WriteLine("Show Matriz");

for (int fila = 0; fila < lado; fila++)
{

    for (int columna = 0; columna < lado; columna++)
    {
        //determinar posicion
        int y = lado - columna - 1;
        //mostrar
        if (columna == lado - 1)
        {
            Console.WriteLine(matriz[lado - fila - 1, y] + " | ");
        }
        else
        {
            Console.Write(matriz[lado - fila - 1, y] + " | ");
        }
    }
}
Console.ReadKey();