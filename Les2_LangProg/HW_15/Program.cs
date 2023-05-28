Console.Write("Insert number of weekday: ");
string s = Console.ReadLine();
if (int.TryParse(s, out int d))
{
    if (d > 0 && d < 8)
    {
        bool l = false;
        if (d == 6 || d == 7) l = true;
        Console.Write($"{d} => {l}");
    }
    else { Console.Write("Значение не верно"); }
}
else { Console.Write("Not number!"); }
