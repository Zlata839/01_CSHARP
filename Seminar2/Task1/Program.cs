// Напишите программу, которая принимает на вход  трёхзначное число и 
// удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num_1 = num % 10;
int num_2 = num / 100;

// Console.WriteLine(num_2 + "" + num_1); склейка без пробела
// Console.WriteLine(num_2 * 10 + num_1); 
// * 10 это что num_2 стал числом из 2 цифр и вторым числом будет num_1
// например 223 стал num_2 - 2,23 а когда * 10 стало 20 вместо 0 подставится num_1

int result = num_2 * 10 + num_1;
Console.WriteLine($"{num} -> {result}");

int result_2 = Convert.ToInt32((num_2 + "" + num_1));
Console.WriteLine($"{num} -> {result_2}");

string num_str = Convert.ToString(num);
Console.WriteLine(Convert.ToString(num_str[0] + Convert.ToString(num_str[2])));
// Добавили Convert.ToString потому что иначе C# считает как тип char
Console.WriteLine(num_str[0] + "" + num_str[2]); 
// Без суммирования тогда склейка