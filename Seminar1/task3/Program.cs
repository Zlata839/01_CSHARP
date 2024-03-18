// Напишите программу, которая принимает на вход трёхзначное целое число и 
// на выходе показывает сумму первой и последней цифры этого числа.

// int n = Convert.ToInt32(Console.ReadLine());
// int first = n % 10;
// int second = n / 10 % 10;
// int thrid = n / 100;
// int sum = first + thrid;
// Console.WriteLine(first);
// Console.WriteLine(second);
// Console.WriteLine(thrid);

// Console.WriteLine(sum);

// Вариант 2
// int n = int.Parse(Console.ReadLine()!);
// int firstNum = n/100;
// int lastNum = n%10;
// int sum = firstNum + lastNum;
// Console.WriteLine(sum);
// Console.WriteLine((n/10)%10);

// Вариант 3
// Console.WriteLine(" введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n / 100;
// int b = n % 10;
// int sum = (a + b); // / 10;

// if (n < 100 || n > 1000)
// {
// Console.Write("это не трехзначное число...");
// }
// else
// {
// Console.Write($" сумма первого и третьего числа {n} равна {sum} ");
// }

// Вариант 4
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 100 && number<999)
// {
// int firstDigit = number / 100;
// int thirdDigit = number % 10 ;
// int result = firstDigit + thirdDigit;
// Console.WriteLine("Сумма чисел = " + result);
// }
// else
// {
// Console.WriteLine("Число не трехзначное ");
// }

// Вариант 5
// Console.WriteLine(" введите трехзначное число: ");
// string n = Console.ReadLine()!;

// if (n.Length != 3)
// {
// Console.Write("это не трехзначное число...");
// }
// else
// {
// Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0]))
//                                     + Convert.ToInt32(Convert.ToString(n[2])));
// }

// Вариант 6
Console.WriteLine(" введите трехзначное число: ");
string n = Console.ReadLine()!;

if (Convert.ToInt32(n) < 100 || Convert.ToInt32(n) > 1000)
{
Console.Write("это не трехзначное число...");
}
else
{
Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0]))
                                    + Convert.ToInt32(Convert.ToString(n[2])));
}