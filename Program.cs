string[] text = new string[4];
Console.Write("Введите первый элемент массива: ");
text[0] = Console.ReadLine()!;
Console.Write("Введите второй элемент массива: ");
text[1] = Console.ReadLine()!;
Console.Write("Введите третий элемент массива: ");
text[2] = Console.ReadLine()!;
Console.Write("Введите четвертый элемент массива: ");
text[3] = Console.ReadLine()!;
Console.WriteLine($"[{String.Join("; ", text)}]");
string[] text2 = GetArray(text);
Console.WriteLine($"[{String.Join("; ", text2)}]");

// ---------Методы------------
string[] GetArray (string[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] shorts = new string[count];
     for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            shorts[i] = Array[i];
        }
        else continue;
    }
    return shorts;
}