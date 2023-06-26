// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
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
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return A(m - 1, 1);
    else return (A(m - 1, A(m, n - 1)));
}
int m = Insert("Введите m для A(m,n): ");
int n = Insert("Введите n для A(m,n): ");
Say($"M = {m}; N = {n} -> A(m,n) = {A(m, n)}");