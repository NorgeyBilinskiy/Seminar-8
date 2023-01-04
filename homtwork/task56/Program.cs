// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       for (int j=0;j<array.GetLength(1);j++) 
            array[i,j] = new Random().Next(-10,10);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
            Console.Write($"{array[i,j],2}\t");
        Console.WriteLine();
       }
}

void MinLines(int[,] array)
{
    int min = 0;
    int minSumm = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < min)
        {
            min = sum;
            minSumm = i;
        }
        sum = 0;
    }
    Console.Write($"{minSumm + 1} строка");
}

Console.WriteLine("Введите количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinLines(array);