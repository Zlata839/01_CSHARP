// Вычеслить фаториал от натурального числа N

int Fact(int n)
{
    if (n == 1 || n == 0)
    {

        //отладочный вывод на ээкран
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1); // нельзя стаивть !, так как в C# это совсем другое значение
}

Console.Write(Fact(5));
