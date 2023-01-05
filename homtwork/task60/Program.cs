// Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] array, int min = 10, int max = 100)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(min, max);

                    if (NumberArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool NumberArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Добрый день!");
Console.WriteLine("Массив имеет размер 2*2*2");
Console.WriteLine("Значения в массиве изменяются от 10 до 99 включительно");

int SizeX = 2;
int SizeY = 2;
int SizeZ = 2;
int[,,] array3D = new int[SizeX,SizeY,SizeZ];

FillArray(array3D);
PrintArray(array3D);
