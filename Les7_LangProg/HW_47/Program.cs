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
            arr[i, j] = new Random().Next(-100,101)/10.0;
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
        }
        Console.WriteLine("\t]");
    }
}
Say("Введите параметры двумерного масива");
double[,] arr = FillRandom2d();
PrintArray(arr);


