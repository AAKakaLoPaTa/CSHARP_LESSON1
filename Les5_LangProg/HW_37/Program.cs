// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        array[i] = new Random().Next(0, 10);
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
string TakeTwinMult(int[] array)
{
    string k = "";
    for (int i = 0; i < array.Length / 2; i++)
    {
        k += array[i] * array[array.Length - i - 1];
        if (i != array.Length / 2) k += " ";
    }
    if (array.Length % 2 != 0) k += array[array.Length / 2];
    return k;
}

int[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"{ArrayToStr(a)} -> {TakeTwinMult(a)}");