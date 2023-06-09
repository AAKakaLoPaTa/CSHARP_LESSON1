int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GetArrayRandom(int q)
{
    int[] array = new int[q];
    for (int i = 0; i < q; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}
int[] CopyArrayByElement(int[] array)
{
    int[] k = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        k[i]=array[i];
    }
    return k;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"[{String.Join(",", a)}] => [{String.Join(",", CopyArrayByElement(a))}]");
