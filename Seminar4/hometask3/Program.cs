// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);        
    }
    return array;
}

void ShowArray(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] GetInvertedArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }
    return array;
} 

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(n);
Console.WriteLine("Исходный массив:");
ShowArray(array);

int[] array2 = GetInvertedArray(array);
Console.WriteLine($"Массив после преобразования (перевернутый):");
ShowArray(array2);
