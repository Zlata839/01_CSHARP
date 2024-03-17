// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел


int a = 4;
int b = 7;
int c = 1;

int max = a;

if (b > max)
{
    return max;
}
if (c > max)
{
    return max;
}
if (a > b)
{
    return max;
}

Console.WriteLine(max);

Вариант 2 

if (num2 < num1 > num3)
{
    return num1;
}

else if (num1 < num2 > num3)
{
    return num2;
}

 else if (num1 < num3 > num2)
 {
    return num3;
}