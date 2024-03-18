// Напишите программу, которая выводит третью слева цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 456  =>  6
// 7812  =>  1
// 91  =>  Третьей цифры нет

int num = new Random().Next(0, 10000);
Console.WriteLine(num);
int res = 0;
if (num < 100)
    while (num > 999 && num < 1001)
    {
        Console.WriteLine($"Третьей цифры нет:{num}");
    }

else
    {
        while (num >= 100)
        {
            res = num % 10;
            num /= 10; // num = num / 10;
            Console.WriteLine($"num:{num}");
            Console.WriteLine($"ответ:{res}");
            Console.WriteLine();
        }

    }




