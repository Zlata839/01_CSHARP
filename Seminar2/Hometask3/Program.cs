// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int n = new Random().Next(11, 100);
// int n = 55;

int firstNumber = n / 10;
int secondNumber = n % 10;

int max = 0;

if (firstNumber > secondNumber)
{
    max = firstNumber;
    Console.Write($"{max} Наибольшая цифра числа {n}");
}
else if (firstNumber == secondNumber)
{
    Console.Write($"Обе цифры числа {n} равны");
}
else
{
    max = secondNumber;
    Console.Write($"{max} Наибольшая цифра числа {n}");
}