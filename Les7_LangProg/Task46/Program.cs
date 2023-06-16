void Say(string say)
{
    Console.WriteLine(say);
}
int Insert(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillRandom2d()
{
    int m = Insert("Введите количество строк: ");
    int n = Insert("Введите количество столбцов: ");
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++) //строки
    {
        for (int j = 0; j < n; j++) //столбцы
        {
            arr[i, j] = new Random().Next(1, 1000);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) //строки
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++) //столбцы
        {
            Console.Write("\t"+arr[i,j]);
            if (j < arr.GetLength(1)-1) {Console.Write(",");}
        }
        Console.WriteLine("\t]");
    }
}
Say("Введите параметры двумерного масива");
PrintArray(FillRandom2d());


