// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.

string Len(int stop, int start = 0)
{
    if (start == stop) return Convert.ToString(stop);
    return start + " " + Len(stop, start + 1);
}

// 5 будет 1 2 3 4 5 
void Len2(int num)
{
    if (num == 0) return;
    Len2(num - 1);
    Console.Write($"{num} ");
}

// 5 будет 5 4 3 2 1 
// void Len2(int num)
// {
//     if (num == 0) return;
//     Console.Write($"{num} ");
//     Len2(num - 1);
// }

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(n));
Len2(n);

// Console.WriteLine(1 + "" + 5);