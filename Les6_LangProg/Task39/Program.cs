// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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
int[] TakeInvertArray(int[] array)
{
    int[] k = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        k[i]=array[array.Length-i-1];
    }
    return k;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"[{String.Join(",", a)}] => [{String.Join(",", TakeInvertArray(a))}]");
