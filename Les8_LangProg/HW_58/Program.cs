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

double[,] Mult2Arrays(double[,] arr1, double[,] arr2)
{
    double[,] mult = new double[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Say("Матрицы не совместимы!", true);
        return new double[0,0];
    }
    else
    {
        for (int i = 0; i < mult.GetLength(0); i++)
        {
            for (int j = 0; j < mult.GetLength(1); j++)
            {
                double s = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    s += arr1[i, k] * arr2[k, j];
                }
                mult[i, j] = s;
            }
        }
        return mult;
    }
}
Say("Матрица № 1:");
double[,] arr1 = FillRandom2d();
Say("Матрица № 2:");
double[,] arr2 = FillRandom2d();
Say("Сгенерированные матрицы из чисел от 1 до 9:", true);
Say("Матрица № 1:", true);
PrintArray(arr1);
Say("Матрица № 2:", true);
PrintArray(arr2);
Say("Их произведение:", true);
PrintArray(Mult2Arrays(arr1, arr2));
