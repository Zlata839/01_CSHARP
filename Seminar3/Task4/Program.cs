// Дано натуральное трёхзначное число. Создайте массив, 
// состоящий из цифр этого числа. Младший разряд числа должен 
// располагаться на 0-м индексе массива, старший – на 2-м.

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

string n = Console.ReadLine()!;
int len = n.Length; 

int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = Convert.ToInt32(Convert.ToString(n[i])); // обращение к первому элементу
}
PrintMas(arr);

int[] arr2 = new int[len];
for (int i = 0; i < len; i++)
{
    arr2[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i])); // обраение к последнему элементу -1 не отнимаем, а указывает на послений элемент
}
PrintMas(arr2);