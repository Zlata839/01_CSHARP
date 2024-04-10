// // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// // в промежутке от M до N. Использовать рекурсию, не использовать циклы.

string PrintNaturalNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + " " + PrintNaturalNumbers(m + 1, n);
}

void PrintNaturalNumbers2(int start, int end)
    {
        if (start > end) return;
        Console.Write(start + " ", end);
        PrintNaturalNumbers2(start + 1, end);
    }

Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {m} до {n}:");
Console.WriteLine(PrintNaturalNumbers(m, n));
PrintNaturalNumbers2(m, n);