// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int GetCount(int[] arr)  
{
    int count = 0;                        
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) 
        {
            count++; 
        }
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(n);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве равно {GetCount(res)}");