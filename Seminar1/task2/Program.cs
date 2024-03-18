// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.

int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while (notN <= N)
{
    Console.Write($"{notN} ");
    notN++;
}
