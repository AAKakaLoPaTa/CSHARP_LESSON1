
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
string ArrayToStr(int[] array)
{
    string s = "[";
    for (int i = 0; i < array.Length; i++)
    {
        s += array[i];
        if (i != array.Length - 1) s += ", ";
    }
    s += "]";
    return s;
}
int[] TakeZeroRedLineSum(int[] array)
{
    int[] k = new int[2];
    // k[0] Отрицательные
    // k[1] Положительные
    // for (int i = 0; i < array.Length; i++)
    // {
    //     if (array[i] < 0) k[0] += array[i];
    //     if (array[i] > 0) k[1] += array[i];
    // }
    foreach (var item in array)
    {
        if (item < 0) k[0] += item;
        if (item > 0) k[1] += item;
    }
    return k;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
// Console.Write($"{ArrayToStr(a)} => {TakeZeroRedLineSum(a)[0]} +{TakeZeroRedLineSum(a)[1]}");
Console.Write($"[{String.Join(",", a)}] => {TakeZeroRedLineSum(a)[0]} +{TakeZeroRedLineSum(a)[1]}");