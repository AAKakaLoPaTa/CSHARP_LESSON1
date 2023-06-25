// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void SayThis(string say, bool warning = false)
{
    if (warning) Console.BackgroundColor = ConsoleColor.Red;
    Console.Write(say);
    if (warning) Console.ResetColor();
}
int Insert(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void rowRec(int a)
{
    if (a == 1) Console.Write(a);
    else
    {
        Console.Write($"{a}, ");
        rowRec(--a);
    }
}
int a = Insert("Введите число: ");
SayThis($"N = {a} -> \"");
rowRec(a);
SayThis($"\"");
