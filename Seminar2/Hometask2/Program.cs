// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.Write($"Не принадлежит к какой-либо плоскости");
}
else if (x > 0 && y > 0)
{
    Console.Write($"Плоскость № 1");
}
else if (x < 0 && y > 0)
{
    Console.Write($"Плоскость № 2");
}
else if (x < 0 && y < 0)
{
    Console.Write($"Плоскость № 3");
}
else
{
    Console.Write($"Плоскость № 4");
}

