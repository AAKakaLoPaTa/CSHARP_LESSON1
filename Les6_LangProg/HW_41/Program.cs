int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
int[] InsertArray(int q)
{
    int[] array = new int[q];
    for (int i = 0; i < q; i++)
    {
        array[i] = Insert($"Введите число № {i+1}: ");
    }
    return array;
}
int countInArray(int[] array)
{
    int tik = 0;
    foreach (var item in array)
    {
        if (item > 0) tik++;
    }
    return tik;
}

int count = Insert("Введите количество вводимых чисел: ");
int[] array = InsertArray(count);
int countInArr = countInArray(array);
Console.WriteLine($"[{String.Join(",", array)}] -> {countInArr}");