// Создать массив  и заполнить числами от 1 до N, где N – некоторое натуральное число и вывести его на экран. 



int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    // Console.WriteLine(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}