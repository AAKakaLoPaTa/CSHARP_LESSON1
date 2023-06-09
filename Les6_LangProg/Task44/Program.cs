int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
double[] GetArrayFibbo(int q)
{
    double[] array = new double[q];
    array[0]=0;
    array[1]=1;
    for (int i = 2; i < q; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

int b = Insert("Введите количество элементов массива: ");
double[] a = GetArrayFibbo(b);
Console.Write($"Если N = {b} -> [{String.Join(";", a)}]");
