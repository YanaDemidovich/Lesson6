// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();
Console.Write("Заполните спирально массив n на n. Введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[n, n];//  метод заполнения спирально массива

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
Matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= Matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > Matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

Console.WriteLine();
PrintArray(Matrix);
Console.WriteLine();

void PrintArray(int[,] array)// метод вывода
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

