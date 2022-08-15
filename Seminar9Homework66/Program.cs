// === Задача 66 === Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
//     M = 1; N = 15-> 120
//     M = 4; N = 8. -> 30

Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)// метод подсчета и вывода на печать
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)// метод который принимает значения m и n
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


// === ИЛИ ===

int SumOfNum(int m, int n)
{
    if (m < n)
    {
        return n + SumOfNum(m,n-1);
    }
    else return n;
}
Console.WriteLine("Input first number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNum(m,n));