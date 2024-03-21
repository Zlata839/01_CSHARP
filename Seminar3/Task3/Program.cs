int[] Append(int len)
{
    int[] list = new int[len];
    for (int i = 0; i < len; i++)
    {
        list[i] = new Random().Next(-100, 101);
    }
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    return list;
}

var len = 6;

var lst = Append(len);

var l = lst.Length;

int index = 0;


while (index < lst.Length / 2)
{
    Console.Write(lst[index] * lst[lst.Length - index - 1] + " ");

    index++;
}