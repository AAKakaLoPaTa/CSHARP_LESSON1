// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
double[] GetArrayRandom(int q)
{
    double[] array = new double[q];
    for (int i = 0; i < q; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*100, 2);
    }
    return array;
}
string ArrayToStr(double[] array)
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
double[] TakeMinMaxDiff(double[] array)
{
    double[] k = new double[3];
    k[0] = array[0]; // Максимум
    k[1] = array[0]; // Минимум
    k[2] = 0; // Разница
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > k[0]) k[0] = array[i];
        if (array[i] < k[1]) k[1] = array[i];
    }
    k[2] = Math.Round(k[0] - k[1], 2);
    return k;
}

double[] a = GetArrayRandom(Insert("Введите количество элементов массива: "));
Console.Write($"{ArrayToStr(a)} -> {TakeMinMaxDiff(a)[0]} - {TakeMinMaxDiff(a)[1]} = {TakeMinMaxDiff(a)[2]}");
