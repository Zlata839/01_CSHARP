// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

using System;
// расскладка кириллица
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

void PrintMass(char[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.Write("Введите символы: ");
string n = Console.ReadLine()!;
char[] mass = new char[n.Length];
for (int i = 0; i < n.Length; i++)
{
    mass[i] = n[i];
}

PrintMass(mass);

