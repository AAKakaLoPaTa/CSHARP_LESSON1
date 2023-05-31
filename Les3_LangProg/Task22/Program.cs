Inser: Console.Write("Введите положительное число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c > 0)
{
    for (int i = 1; i <= c; i++)
    {
        if (i > 1) { Console.Write(","); }
        Console.Write(i * i);
    }
}
else { goto Inser; }