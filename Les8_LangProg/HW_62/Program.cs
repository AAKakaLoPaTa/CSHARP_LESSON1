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
double[,] FillSpiral()
{
    int m = Insert("Введите количество строк: ");
    int n = Insert("Введите количество столбцов: ");
    double[,] arr = new double[m, n];
    int i = 0;
    int iMin = 0;
    int iMax = arr.GetLength(0);
    int j = 0;
    int jMin = 0;
    int jMax = arr.GetLength(1);
    int count = 1;
    string direction = "right";
    foreach (var item in arr)
    {
        arr[i, j] = count;
        count++;
        if (direction == "right")
        {
            if (j + 1 >= jMax)
            {
                direction = "down";
                i++;
                jMax--;
            }
            else
            {
                j++;
            }

        }
        else if (direction == "down")
        {
            if (i + 1 >= iMax)
            {
                direction = "left";
                j--;
                iMax--;
            }
            else
            {
                i++;
            }
        }
        else if (direction == "left")
        {
            if (j - 1 < jMin)
            {
                direction = "up";
                i--;
                jMin++;
            }
            else
            {
                j--;
            }
        }
        else if (direction == "up")
        {
            if (i - 1 <= iMin)
            {
                direction = "right";
                j++;
                iMin++;
            }
            else
            {
                i--;
            }
        }
    }
    return arr;
}
Say("Введите размер массива для спирального заполнения");
double[,] arr = FillSpiral();
Say("Сгенерированный массив:");
PrintArray(arr);
Say("Нельзя так издеваться над живыми людьми! )))",  true);