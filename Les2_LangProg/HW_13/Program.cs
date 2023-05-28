Console.Write("Insert digit: ");
string s = Console.ReadLine();
if (int.TryParse(s, out int d))
{
    if (s.Length > 2)
    {
        Console.Write($"{d} => {s[2]}");
    }
    else { Console.Write("третьей цифры нет!"); }
}
else { Console.Write("Not digit!"); }