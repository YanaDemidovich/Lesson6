// === Задача 64 === Задайте значение N. 
// Напишите программу, которая найдет кол-во цифр 
// в числе N рекурсивным методом.
// N = 4532 -> 4

Console.Clear();

int Recur(int n)// метод рекурсивный
{
    return n < 10 ? 1 : 1 + Recur(n / 10);
}
void Print(string[] args)// метод вывода на печать
{
    Console.Write("Введите n=");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Recur(n));
    Console.ReadKey(true);
}

Print(args);


// === ИЛИ ===

int Numbers(int n)
{
    if (n/10 != 0) return Numbers(n / 10) + 1;
    else return 1;
}
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(n));