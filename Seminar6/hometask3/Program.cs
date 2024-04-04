// Задайте произвольную строку. Выясните, является ли она палиндромом. 
// (Справа на лево и слева на право читается одинаково).

using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

bool IsPalindrom(string str)
{
    bool a = false;
    bool b = false;
    int count = 0;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] == str[str.Length - i - 1])
        {
            a = true;
            if (a)
            {
                count++;
            }
        }
    }
    if (count == str.Length / 2)
    {
        b = true;
    }
    return b;
}

void Print(bool str)
{
    if (str)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

string str = "шалаш";
bool isPalindrom = IsPalindrom(str);
Print(isPalindrom);

