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
int Gen()
{
    return new Random().Next(10, 100);
}
int[,,] FillRandom3d()
{
    int m = Insert("Введите количество строк: ");
    int n = Insert("Введите количество столбцов: ");
    int o = Insert("Введите количество слоев: ");
    if (m * n * o > 90)
    {
        Say("Невозможно создать массив заданной размерности из двузначных (положительных) неповторяющихся чисел!", true);
        return new int[0, 0, 0];
    }
    int[,,] arr = new int[m, n, o];
    int[] line = new int[100];
    for (int i = 0; i < o; i++) //слои
    {
        for (int j = 0; j < m; j++) //строки
        {
            for (int k = 0; k < n; k++) //столбцы
            {
                int d = Gen();
            GT: if (line[d] == 1)
                {
                    d = Gen();
                    goto GT;
                }
                line[d] = 1;
                arr[j, k, i] = d;
            }
        }
    }
    return arr;
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++) //слои
    {
        for (int j = 0; j < arr.GetLength(0); j++) //строки
        {
            for (int k = 0; k < arr.GetLength(1); k++) //столбцы
            {
                if (k > 0) Console.Write(" ");
                Console.Write($"{arr[j, k, i]}({j},{k},{i})");
            }
            Say("");
        }
    }

}

int[,,] arr = FillRandom3d();
if (arr.GetLength(0) != 0 && arr.GetLength(1) != 0 && arr.GetLength(2) != 0)
{
    Say("Сгенерированная матрица:");
    Print3DArray(arr);
}
