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
            arr[i, j] = new Random().Next(-10, 11);
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
double[,] SrtStringsArray(double[,] array, string sorttype = "ASC")
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if ((sorttype == "ASC" && array[k, i] > array[k, j]) || (sorttype == "DESC" && array[k, i] < array[k, j]))
                {
                    double t = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = t;
                }
            }
        }
    }
    return array;
}
double[,] arr = FillRandom2d();
Say("Сгенерированный массив чисел от -10 до 10");
PrintArray(arr);
Say("Массив с отсортированными строками");
PrintArray(SrtStringsArray(arr, "DESC"));
