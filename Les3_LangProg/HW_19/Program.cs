string Insert(int n)
{
GT1: Console.Write($"Введите {n}-значное число: ");
    string s = Console.ReadLine();
    if (s.Length != n)
    {
        Console.WriteLine($"Ошибка: требуется ввести {n} символов!");
        goto GT1;
    }
    if (int.TryParse(s, out int zero))
    {
        return s;
    }
    else
    {
        Console.WriteLine($"Ошибка: введенное значение не является числом!");
        goto GT1;
    }

}
string IsPalindrom(string dig)
{
    for (int i = 0; i < dig.Length / 2; i++)
    {
        if (dig[i] != dig[dig.Length - 1 - i])
        {
            return $"Значение {dig} не является палиндромом";
        }
    }
    return $"Значение {dig} является палиндромом";

}

Console.WriteLine(IsPalindrom(Insert(5)));