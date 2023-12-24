// Задача 1
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(int[,] matrix)
{
    for (int i=0; i <matrix.GetLength(0); i++)
    {
        for (int j=0; j <matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i=0; i <matrix.GetLength(0); i++)
    {
        for (int j=0; j <matrix.GetLength(1); j++)
        {
            if ( matrix[i, j] >= 0)  Console.Write(" ");
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Задайте размер маттрицы: ");

int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите индексы элемента двумерного массива: ");
int[] index = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();

if (index[0] >= size[0] && index[1] >= size[1]) Console.Write("Элемента с таким индексом нет в массиве");
else Console.Write($"Значение выбранного элемента массива: {matrix[index[0], index[1]]}");


