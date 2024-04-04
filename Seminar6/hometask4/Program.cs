// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string[] GetInvertedArray(string[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
    }
    return array;
}

void ShowArray(string[] col)
{
    foreach (string item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

}

string str = "Hello my world";
string[] arr = str.Split(" ");

string[] res = GetInvertedArray(arr);
ShowArray(res);
