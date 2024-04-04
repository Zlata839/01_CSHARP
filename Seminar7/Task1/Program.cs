// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumNum(int num)
{
    if (num == 0) return 0;
    int res = num % 10 + SumNum(num / 10);
    return res;
}

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(n));