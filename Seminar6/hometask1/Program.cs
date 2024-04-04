// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// Вариант 1
string CharOfString(char[,] arr)
{
    string st = ""; // обязательно двойные ковычки

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine(i);
            st += arr[i, j];
        }
    }
    return st;
}

// Вариант 2
void CharOfString2(char[,] arr)
{
    string st = ""; // 
    foreach (var i in arr)
    {
        Console.WriteLine(i);
        st += i; // st = st + i
    }
    Console.WriteLine(st);
}


char[,] chars = new char[,] 
{
    { 'a', '1' },
    { 'c', 'd' } 
};
Console.WriteLine(CharOfString(chars));
CharOfString2(chars);