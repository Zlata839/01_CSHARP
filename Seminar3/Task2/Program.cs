// Задайте массив из 10 элементов, заполненный числами из промежутка 
// [-10, 10]. Замените отрицательные элементы на положительные, 
// а положительные на отрицательные.

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item}\t ");
    }
    Console.WriteLine();
}

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(-10, 11); // задаем наш диапозон
    }
    return col;
}

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomMas(new int[n]);
PrintMas(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1; //меняем отрицательные на положительные и наоборот
}
PrintMas(arr);