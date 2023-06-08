// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArrayRandom(int q)
{
    int[] array = new int[q];
    for (int i = 0; i < q; i++)
    {
        array[i] = new Random().Next(0, 1000);
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
int TakeCount10To99(int[] array, int fromEq, int toEq)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= fromEq && array[i] <= toEq) k++;
    }
    return k;
}
int[] a = GetArrayRandom(123);
Console.Write($"{ArrayToStr(a)} -> {TakeCount10To99(a,10,99)}");