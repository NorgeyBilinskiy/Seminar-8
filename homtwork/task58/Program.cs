// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-9,10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine("Введите размеры матриц:");
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк 2-й матрицы: ");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица: ");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
FillArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[v,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);

Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);




