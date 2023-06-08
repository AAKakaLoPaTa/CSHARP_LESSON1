int Insert()
{
    Console.Write("Insert number: ");
    return Convert.ToInt32(Console.ReadLine());
}
void SumDigits(int n)
{
    int s = 0;
    while (n > 0)
    {
        s += n % 10;
        n /= 10;
    }
    Console.WriteLine($"-> {s}");

}
SumDigits(Insert());