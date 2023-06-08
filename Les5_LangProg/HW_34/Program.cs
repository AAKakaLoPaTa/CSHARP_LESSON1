// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        array[i] = new Random().Next(100, 1000);
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
int TakeCountEven(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) k++;
    }
    return k;
}
int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"{ArrayToStr(a)} -> {TakeCountEven(a)}");