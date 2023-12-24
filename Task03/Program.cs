// Задача 3
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

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

int[] ReleaseMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
        }
        array[i] = summa;
    }
    return array;
}

int MaxNumber(int[] array)
{
    int max = array[0];
    int maxIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
            maxIndex = i;
        }
    }
    return maxIndex;
}

Console.Clear();
int[,] matrix = new int[4, 4];
int[] array;

InputMatrix(matrix);
Console.WriteLine("Сгенерированная матрица: ");
PrintMatrix(matrix);
Console.WriteLine();

array = ReleaseMatrix(matrix);
Console.WriteLine("Суммы чисел по строкам: ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

int maxIndex = MaxNumber(array);
int normalCount = maxIndex + 1;
Console.WriteLine($"Строка с максимальным индексом: {normalCount}");
Console.WriteLine();
