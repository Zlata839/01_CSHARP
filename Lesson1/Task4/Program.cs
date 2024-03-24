// Дано 5 гирь с разным весом в случайно порядке. Найти вес самой тяжелой гири
//Задача с пятью гирями

int a = 6;
int b = 7;
int c = 9;
int d = 4;
int e = 10;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);