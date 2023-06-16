void Say(string say)
{
    Console.WriteLine(say);
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
double[] AvgColumn(double[,] arr)
{
    double[] arrAvg = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(1); i++) //столбцы
    {
        double s = 0;
        for (int j = 0; j < arr.GetLength(0); j++) //строки
        {
                s += arr[j,i];
        }
        arrAvg[i]=Math.Round((double)s/arr.GetLength(1),1);
    }
    return arrAvg;
}
Say("Введите параметры двумерного масива");
double[,] arr = FillRandom2d();
Say("Сгенерированный массив");
PrintArray(arr);
Say("Среднее арифметическое каждого столбца: " + String.Join("; ",AvgColumn(arr))+".");


