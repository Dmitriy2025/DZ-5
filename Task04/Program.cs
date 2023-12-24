// Задача 4
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0) Console.Write(" ");
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] MinIndex(int[,] array)
{
    int min = array[0, 0];
    int[] minIndex = new int[] { 0, 0 };

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minIndex[0] = i;
                    minIndex[1] = j;
                }
            }
    }
    return minIndex;
}

void PrintNewMatrix(int [,] matrix, int [] minIndex)
{
    Console.WriteLine("Новая матрица: ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        if (i == minIndex[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minIndex[1]) continue;
            {
                if (matrix[i, j] >= 0) Console.Write(" ");
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}



Console.Clear();
int[,] matrix = new int[4, 4];

InputMatrix(matrix);
Console.WriteLine("Изначальная матрица: ");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

int[] minIndex = MinIndex(matrix);

PrintNewMatrix(matrix, minIndex);
