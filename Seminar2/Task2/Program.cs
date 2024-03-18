// Напишите программу, которая принимает на вход трёхзначное число и 
// возводит вторую цифру этого числа в степень, равную третьей цифре.


int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num_1 = num % 100;
int num_2 = num_1 / 10;
int num_3 = num_1 % 10;
Console.WriteLine($"num_1:{num_1}");
Console.WriteLine($"num_2:{num_2}");
Console.WriteLine($"num_3:{num_3}");
Console.WriteLine($"результат:{Math.Pow(num_2,num_3)}");

int i = 0;
int c = 1;
Console.WriteLine();
while (i < num_3)
{
        c *= num_2;
        Console.WriteLine(c);
        i++;
}