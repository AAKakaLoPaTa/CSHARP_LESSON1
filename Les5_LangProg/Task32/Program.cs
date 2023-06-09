
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
        array[i] = new Random().Next(-9,10);
    }
    return array;
}
int[] TakeInvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=array[i]*(-1);
    }
    return array;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
// Console.Write($"{ArrayToStr(a)} => {TakeZeroRedLineSum(a)[0]} +{TakeZeroRedLineSum(a)[1]}");
Console.WriteLine($"Исходный массив [{String.Join(",", a)}]");
Console.WriteLine($"Инвертированный массив [{String.Join(",", TakeInvertArray(a))}]");