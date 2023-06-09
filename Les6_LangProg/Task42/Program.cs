int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
string Bin(int dec)
{
    string s = "";
    if (dec / 2 > 0 || (dec / 2 == 0 && dec % 2 != 0))
    {
        s = Bin(dec / 2) + Convert.ToString(dec % 2) + s;
    }
    return s;
}
int a = Insert("Введите десятичное число: ");
Console.WriteLine($"{a} -> {Bin(a)}");
