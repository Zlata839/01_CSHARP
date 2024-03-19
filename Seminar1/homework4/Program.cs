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


using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже

int i = 1;

while (i <= number)

    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        i++;
    }
    else
    {
        i++;
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 5;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}  
