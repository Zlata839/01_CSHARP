// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если первое число некратно
//  второму, то программа выводит остаток от деления

string Test(int first, int second)
{
        if (second == 0) { return "Деление на 0!"; }

        int res = first % second;

        if (res == 0)
        {
                return "Да";
        }
        else
        {
                return $"Нет, {res}";
        }
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Test(num1, num2));


if (num2 == 0) { Console.WriteLine("Деление на 0!"); }
else
{
        int res = num1 % num2;

        if (res == 0)
        {
                Console.WriteLine("Да");
        }
        else
        {
                Console.WriteLine($"Нет, {res}");
        }
}