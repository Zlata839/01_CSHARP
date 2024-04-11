// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m, n)
// n + 1, при m = 0;
// A(m - 1, 1), при m > 0, n = 0;
// A(m - 1, A(m, n - 1)), при m > 0, n > 0;

int AkkermanFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
        return AkkermanFunction(m - 1, 1);
    }
    else 
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {AkkermanFunction(m, n)}");

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m, n);
// }

