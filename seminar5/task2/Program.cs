// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] RandomMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++) // GetLength обрашение к m
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i, j] = new Random().Next(0, 10);
        }
    }
    return col;
}

void PrintMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++) 
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
           Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }    
}

//вариант 1
// int Diagsum(int[,] col)
// {
//     int res = 0;
//     for (int i = 0; i < col.GetLength(0); i++) 
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                res += col[i, j];
//             }
//         }
       
//     }   
//     return res;
// }

// Console.Write("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];
// int[,] arrRandom = RandomMas(arr);
// PrintMas(arrRandom);
// Console.WriteLine();
// int res = Diagsum(arrRandom);

// Console.WriteLine("sum = " + res);


//вариант 2
// определяем чего меньше кол-во строк или кол-во столбцов
int SearchMin(int[,] col)
{
    if (col.GetLength(0) < col.GetLength(1))
    {
        return col.GetLength(0);
    }
    return col.GetLength(1);
}

// идетм по индексам [0,0], [1,1], а min Для того если кол-во строк и столбцов разное
// 8[0] 1[1] 5[2] 6[3] 
// 8[0] 9[1] 2[2] 6[3]
// 3[0] 2[1] 6[2] 8[3]

// sum = 23 (8+9+6)

int Diagsum(int[,] col, int min)
{
    int res = 0;
    for (int i = 0; i < min; i++) 
    {
       res += col[i, i];  
    }   
    return res;
}

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] arrRandom = RandomMas(arr);
PrintMas(arrRandom);
Console.WriteLine();
int res = Diagsum(arrRandom, SearchMin(arrRandom));

Console.WriteLine("sum = " + res);