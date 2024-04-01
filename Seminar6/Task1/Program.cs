// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string CharOfString(char[] arr)
{
    string st = ""; // обязательно двойные ковычки
    for (int i = 0; i < arr.Length; i++)
    {
        st += arr[i];         
    }
    return st;
}

string CharOfString2(char[] arr)
{
    string st = ""; // 
    foreach (var i in arr)
    {
        st += i; // st = st + i
    }
    return st;
}

char[] chars = new char[] {'a', '1', 'c', 'd'};
// string st = CharOfString(chars);
Console.WriteLine(CharOfString(chars));
Console.WriteLine(CharOfString2(chars));

// string st2 = "12345";
// for (int i = 0; i < st2.Length; i++)
// {
//     Console.WriteLine(st2[i]);
// }