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

//Ответ
public class Task1
{
//     public static void Main(string[] args)
//     {
//         // Инициализация двумерного массива символов
//         char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
//         // Вызов метода для создания строки из 2D массива
//         string result = CreateStringFrom2DArray(charArray);
//         // Вывод результата
//         Console.WriteLine(result);
//     }
//     // Метод для создания строки из двумерного массива символов
//     public static string CreateStringFrom2DArray(char[,] array)
//     {
//         string result = "";
//         // Цикл по каждому элементу в двумерном массиве
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 // Добавление каждого символа в результирующую строку
//                 result += array[i, j];
//             }
//         }
//         return result;
//     }
// }