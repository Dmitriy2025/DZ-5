// Задача 2 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void InputMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10,11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i=0; i <matrix.GetLength(0); i++)
    {
        for (int j=0; j <matrix.GetLength(1); j++)
        {
            if ( matrix[i, j] >= 0) Console.Write(" ");
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j] = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = array[j];
    }
}

Console.Clear();
Console.Write("Задайте размер маттрицы: ");

int [] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];
int [] array = new int [size[0]];

InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Измененная матрица: ");
PrintMatrix(matrix);