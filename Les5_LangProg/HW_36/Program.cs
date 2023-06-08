// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(0, 100);
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
int TakeEvenPosAmount(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) k += array[i];
    }
    return k;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"{ArrayToStr(a)} -> {TakeEvenPosAmount(a)}");