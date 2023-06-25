// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Say(string say, bool warning = false, bool breakLine = true)
{
    if (warning) Console.BackgroundColor = ConsoleColor.Red;
    if (breakLine) Console.WriteLine(say);
    else Console.Write(say);
    if (warning) Console.ResetColor();
}
int Insert(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sumRowRec(int m, int n)
{
    if (m > n)
    {
        Say("Первое число больше второго!", true);
        return m;
    }
    else
    {
        if (m == n) return n;
        return m + sumRowRec(++m, n);
    }
}
int m = Insert("Введите начальное натуральное число диапазона: ");
int n = Insert("Введите конечное натуральное число диапазона: ");
Say($"M = {m}; N = {n} -> {sumRowRec(m, n)}");
