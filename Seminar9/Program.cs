// === Задача 1 === Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

Console.WriteLine();

void ShowNums(int n)//метод который выдает от 1 до N.
{
    if (n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

// (5) -> (4) -> (3) ->( 2) -> (1) wl(1) -> (2) wl(2) -> (3) wl(3) ->(4) wl(4) ->(5) wl(5)

ShowNums(5);
Console.WriteLine();


Console.WriteLine();
void ShowNums1(int n) //метод который выдает от N до 1.
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        ShowNums1(n - 1);
    }
}

ShowNums1(5);
Console.WriteLine();



// === Задача 2 ==== Напишите программу, которая будет принимать на вход число  
// и возвращать сумму его цифр.


int SumOfDigits(int n)// метод который суммирует чисо всех элементов
{
    if (n >= 10)
    {
        return n % 10 + SumOfDigits(n/10);
    }
    else return n;
}
Console.WriteLine();
Console.WriteLine(SumOfDigits(1234));

// === Задача 3 === Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

void ShowNums2(int n, int m)// метод упорядоченивания от меньшнго к большему
{
    if (n < m) ShowNums2(n, m - 1);

    Console.Write(m + " ");
}
Console.WriteLine();
ShowNums2(2, 15);
Console.WriteLine();


// === Задача 4 === Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

double Stepen(double a, double b)//метод возводит число А в целую степень B с помощью рекурсии
{
    if (b > 0)
    {
        return a * Stepen(a, b - 1);
    }
    else if (b < 0)
    {
        return 1 / a * Stepen(a, b + 1);
    }
    else return 1;
}

Console.WriteLine();
Console.WriteLine(Stepen(2, -3));
Console.WriteLine();
