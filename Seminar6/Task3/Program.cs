// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aouei).


using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int FindVowels(string str)
{
    string vowels = "aoueiуеаояиыюэAOUEIУЕЫАОЭЯИЮ";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    { 
       for (int j = 0; j < vowels.Length; j++) 
       {
        if (str[i] == vowels[j])
        {
            count++;
            break;
        }
       }
    }
    return count;
}

Console.Write("Введите строку: ");
string n = Console.ReadLine()!;
int res = FindVowels(n);
Console.WriteLine(res);



