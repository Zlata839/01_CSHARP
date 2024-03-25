// Заполните массив на N (вводится с консоли, не более 8) 
// случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(0, 9);
        Console.Write($"{Number[i]}, ");
    }
    return Number;

}

// Функция подбора
string FindFirstAndLast(int[] col)
{
    string number = "";
    for (int i = 0; i < col.Length; i++)
    {
        number = number + Convert.ToString(col[i]);
    }
    return number;
}

Console.Write("Введите размерность массива не более 8: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomMass(n);
string str = FindFirstAndLast(arr);
Console.WriteLine();
Console.WriteLine(str);