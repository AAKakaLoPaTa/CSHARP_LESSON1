
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
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
string FindInArray(int[] array, int digit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit) return "ДА";
    }
    return "НЕТ";
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
int d = Insert("Загадайте число: ");
// Console.Write($"{ArrayToStr(a)} => {TakeZeroRedLineSum(a)[0]} +{TakeZeroRedLineSum(a)[1]}");
Console.WriteLine($"{d}: массив [{String.Join(",", a)}] -> {FindInArray(a, d)}");