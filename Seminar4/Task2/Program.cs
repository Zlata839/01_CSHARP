// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

int[] RandomMass(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
        Console.Write($"{col[i]}, ");
    }
    return col;
}

int Count(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 10 == 1 && col[i] % 7 == 0)
        {
            Console.WriteLine();
            Console.Write($"Подпадающие числа: {col[i]} ");
            count++;
        }
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int[] mass = RandomMass(arr);
int count = Count(mass);
Console.WriteLine();
Console.WriteLine($"Количество = {count}");

