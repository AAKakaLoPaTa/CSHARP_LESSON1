int Insert(string c)
{
    Console.Write($"Insert digit {c}: ");
    return Convert.ToInt32(Console.ReadLine());
}
void Pow(int a, int b)
{
    Console.Write($"{Math.Pow(a,b)} ({a}^{b})");
}
Pow(Insert("A"),Insert("B"));