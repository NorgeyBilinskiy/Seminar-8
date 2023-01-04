// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
            Console.Write($"{array[i,j],2}\t");
        Console.WriteLine();
       }
}

void ChangeArray(int [,] array)
{
for (int j=0;j<array.GetLength(1);j++)

 (array[0,j], array[array.GetLength(0)-1,j]) = (array[array.GetLength(0)-1,j],array[0,j]);

}

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       for (int j=0;j<array.GetLength(1);j++) 
            array[i,j] = new Random().Next(-10,10);
}

Console.WriteLine("Введите количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);
