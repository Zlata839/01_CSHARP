﻿// Вычислить значение формулы (a*b)/(c+d), где a,b,c,d - некоторые целые числа. Решение оформить в виде функции

double CalculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denomerator = c + d;
    double result = numerator / denomerator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);

