void Say(string say, bool warning = false)
{
    if (warning) Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(say);
    if (warning) Console.ResetColor();
}
string InsertString(string text)
{
    Console.Write(text);
    return Console.ReadLine();
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
double[,] FillRandom2dSquare()
{
    int m = Insert("Введите размер квадратной матрицы: ");
    double[,] arr = new double[m, m];
    for (int i = 0; i < m; i++) //строки
    {
        for (int j = 0; j < m; j++) //столбцы
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
string FindEl(double d, double[,] arr)
{
    string s = String.Empty;
    for (int i = 0; i < arr.GetLength(0); i++) //строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) //столбцы
        {
            if (arr[i, j] == d)
            {
                s += $" [{i}, {j}]";
            }
        }
    }
    if (s == String.Empty)
    {
        return $"{d} -> такого числа в массиве нет";
    }
    else
    {
        return $"Адреса всех элементов числа {d} в массиве ->{s}";
    }
}
int[] TryParseToCoordinate(string c)
{
    int[] arr = new int[2];
    int i = 0;
    string d = String.Empty;
    foreach (var item in c)
    {
        if (i == 2) break;
        if (item == ',')
        {
            int.TryParse(d, out arr[i]);
            i++;
            d = String.Empty;
        }
        if (Char.IsNumber(item))
        {
            d += item;
        }
    }
    if (i < 2) int.TryParse(d, out arr[i]);
    Say($"Распознаны следующие координаты [{String.Join("; ", arr)}]");
    return arr;
}
string GetElementArrByCoordinate(int[] coord, double[,] arr)
{
    if (coord[0] < arr.GetLength(0) && coord[1] < arr.GetLength(1))
    {
        return $"[{String.Join("; ", coord)}] -> {arr[coord[0], coord[1]]}";
    }
    else
    {
        return $"[{String.Join("; ", coord)}] -> такого числа в массиве нет";
    }
}
double[,] RotateStringsArray(int s1, int s2, double[,] arr)
{
    double[,] arrNew = new double[arr.GetLength(0), arr.GetLength(1)];
    if (s1 >= arr.GetLength(0) || s2 >= arr.GetLength(0))
    {
        Say("Строки выходят за диапазон!", true);
        return arr;
    }
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++) //строки
        {
            for (int j = 0; j < arr.GetLength(1); j++) //столбцы
            {
                if (i == s1) arrNew[s2, j] = arr[i, j];
                else if (i == s2) arrNew[s1, j] = arr[i, j];
                else arrNew[i, j] = arr[i, j];
            }
        }
        return arrNew;
    }
}
double[,] RotateStringsColumnsArray(double[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1)) {
        Say("Матрица не является квадратной! Инвертирование невозможно",true);
        return arr;
    }
    double[,] arrNew = new double[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++) //строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) //столбцы
        {
            arrNew[i, j] = arr[j, i];
        }
    }
    return arrNew;
}
double[,] arr = FillRandom2dSquare();
Say("Сгенерированный массив чисел от 1 до 9");
PrintArray(arr);
double[,] arrRotateSC = RotateStringsColumnsArray(arr);
Say("Измененный массив чисел");
PrintArray(arrRotateSC);
