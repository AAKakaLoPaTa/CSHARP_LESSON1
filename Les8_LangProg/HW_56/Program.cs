void Say(string say, bool warning = false)
{
    if (warning) Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(say);
    if (warning) Console.ResetColor();
}
int Insert(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] FillRandom2d()
{
    int m = Insert("Введите количество строк: ");
    int n = Insert("Введите количество столбцов: ");
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++) //строки
    {
        for (int j = 0; j < n; j++) //столбцы
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) //строки
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++) //столбцы
        {
            Console.Write("\t" + arr[i, j]);
            if (j < arr.GetLength(1) - 1) { Console.Write(","); }
        }
        Console.WriteLine("\t]");
    }
}
string PrintStringArray(double[,] arr, int n)
{
        string s = "[";
        for (int j = 0; j < arr.GetLength(1); j++) //столбцы
        {
            s+="\t" + arr[n, j];
            if (j < arr.GetLength(1) - 1) { s+=","; }
        }
        s+="\t]";
    return s;
}

void ExtremumFindSumStringsArray(double[,] array, string exttype = "MAX")
{
    double[] sums = new double[array.GetLength(0)];
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sums[k] += array[k, i];
        }
    }
    double o = sums[0];
    int ii = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if (exttype == "MAX" && sums[i] > o) {
            o = sums[i];
            ii = i;
        }
        if (exttype == "MIN" && sums[i] < o) {
            o = sums[i];
            ii = i;
        }
    }
    Say($"Строка №{ii} - >\t{PrintStringArray(array, ii)} - {exttype} сумма = {o}");
}
double[,] arr = FillRandom2d();
Say("Сгенерированный массив чисел от 1 до 9");
PrintArray(arr);
Say("Ответ");
ExtremumFindSumStringsArray(arr, "MIN");
