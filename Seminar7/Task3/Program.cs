// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

void Consonants(string s)
{
    if (s.Length == 0) return;
    string st = "aoueiy";
    if (st.Contains(s[0]) == false) Console.Write($"{s[0]}");
    // Contains проверяет есть ли это true лт false
    // если true то это false, а если  false то  - на - = +
    Consonants(s[1..]);
}

void Consonants2(string s, int i = 0)
{
    string st = "aoueiy";
    if (i == s.Length) return;
    if (!st.Contains(s[i])) Console.Write($"{s[i]}"); // !
    Consonants2(s, i + 1);
}

string st = Console.ReadLine()!;
Consonants(st);
Console.WriteLine();
Consonants2(st);

// Console.WriteLine(false);
// // если добавить ! то станет true
// Console.WriteLine(!false); 

//s[1..] примеры
// string st = "qwersdgdgdgdgdgdgdg";
// Console.WriteLine(st[2..5]);
// string[] mas = new string[]{"1","2", "3"};
// string[] mas2 = mas[2..];
// Console.WriteLine(mas2[0]);