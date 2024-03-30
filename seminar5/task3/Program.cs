// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный
//массив, состоящий из средних арифметических значений по строкам 
// двумерного массива.

//Вариант Артема

// int[,] UpdateList(int[,] list)
// {
//     for (int i = 0; i < list.GetLength(0); i++)
//     {
//         for (int j = 0; j < list.GetLength(1); j++)
//         {
//             list[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return list;
// }
// void PrintList(int[,] list)
// {
//     for (int i = 0; i < list.GetLength(0); i++)
//     {
//         for (int j = 0; j < list.GetLength(1); j++)
//         {
//             Console.Write($"{list[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] SerchList(int[,] list)
// {
//     int[] res = new int[list.GetLength(0)];
//     int resultStr;
//     for (int i = 0; i < list.GetLength(0); i++)
//     {
//         resultStr = 0;
//         for (int j = 0; j < list.GetLength(1); j++)
//         {
//             resultStr += list[i, j];
//         }
//         res[i] = resultStr / list.GetLength(1);
//     }
//     return res;
// }
// Console.Write("Enter size...");
// int firstSize = int.Parse(Console.ReadLine()!);

// Console.Write("Enter size2...");
// int secondSize = int.Parse(Console.ReadLine()!);

// int[,] list2D = new int[firstSize, secondSize];
// list2D = UpdateList(list2D);
// PrintList(list2D);
// var list = SerchList(list2D);

// foreach (var n in list)
// {
//     Console.WriteLine(n);
// }


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Print2(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

// сумма каждого массива { 2, 3, 4, 3 } = 12 , { 4, 3, 4, 1 } = 12, { 2, 9, 5, 4 } = 20 
int[] Sum(int[,] num1)
{
    int[] summa = new int[num1.GetLength(0)];
    for (int i = 0; i < num1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < num1.GetLength(1); j++)
        {
            sum = sum + num1[i, j];
        }
        summa[i] = sum;
    }
    return summa;
}

//среднее арифмитическое, сумма уже известна, осталось деление
double[] Middle(int[] a, int[,] b)
{
    // вариант1 - переменная с длиной первоначального двумерного массива
    // вариант2
    double[] c = new double[b.GetLength(0)];
    //вариант3
    //double[] c = new double[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        c[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(0));
    }
    return c;
}

int[,] num1 = { { 2, 3, 4, 3 }, 
                { 4, 3, 4, 1 }, 
                { 2, 9, 5, 4 } };
int[] num2 = Sum(num1);
Print(num2);
double[] num3 = Middle(num2, num1);
Print2(num3);
