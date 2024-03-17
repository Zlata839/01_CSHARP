// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

// int N = Convert.ToInt32(Console.ReadLine())


// while ((N % 2) == 0)
// {
//     Console.Write($"{N} ");
//     N++;
// }

// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i < N)
// {
//     Console.WriteLine(i + 1);
//     i += 2;
// }

// Вариант 2
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)

    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        i++;
    }
    else
    {
        i++;
    }