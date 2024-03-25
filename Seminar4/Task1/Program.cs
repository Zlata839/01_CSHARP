// Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.
// простое число, детится на себя и на 1

int [] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1,100);
    }
    return Number;

}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
     Console.WriteLine();
}

bool prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return false;
    }
    Console.WriteLine(num);
    return true;
}


int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i)) count++;
    }
    return count;
}
// посчитываем количество обращений

Console.Write("Введите размерность массива ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMass(n);
PrintMass(mas);
Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");

