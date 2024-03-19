// Напишите программу, которая на ввод принимает число и выдает, является ли число четным.

//   int x = Convert.ToInt32(Console.ReadLine());
//         if ((x % 2) == 0)
//         {
//             Console.WriteLine("chentoe");
//         }
//         else
//         {
//             Console.WriteLine("nechentoe");
//         }

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже

if ((number % 2) == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
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
        CheckIfEven(number);
    }
}