﻿// Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве. Программа должна выдать ответ: Да/Нет.

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

// Console.WriteLine(mas);

// while
int ind = 0;
while (ind < mas.Length) // строгое неравенство
{
    Console.Write($"{mas[ind]} ");
    ind++;
}
Console.WriteLine(); // чтобы не было слипания

//for цикл перебора
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();

//foreach только перебор, без внесения изменений
foreach (int item in mas)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

//функция
void PrintMas(int[] col) //  void универсальная функция которая не возвращает ничего
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

PrintMas(mas);

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 9);
    }

    return col;
}

int[] new_mas = RandomMas(mas);
PrintMas(new_mas);

// решение задачи
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int flag = 0;
foreach (var item in new_mas)
{
    if (item == m)
    {
        flag++; // если число есть увеличиваем на 1
    }
}

if (flag > 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// ваинат 2 решения
string S(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Да";
    }
    return "Нет";
}
Console.WriteLine(S(new_mas, m));

