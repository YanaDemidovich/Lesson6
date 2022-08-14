// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // метод, который задает 2D массив
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue) + 1;

    return newArray;
}

void PrintArray(int[,] array) // метод, который выводит массив на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ReversMatrix(int[,] array) // метод, который упорядочивает элементы каждой строки от min к max
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Неверный формат матрицы!");
        return array;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовое значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовое значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine();
PrintArray(myArray);
PrintArray(ReversMatrix(myArray));