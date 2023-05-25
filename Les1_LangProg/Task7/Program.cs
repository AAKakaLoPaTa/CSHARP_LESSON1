Console.Write("Insert digit: ");
string d = Console.ReadLine();
int digit;
if (d.Length == 3 && int.TryParse(d, out digit))
{
    Console.WriteLine(d[d.Length - 1]);
}
else
{
    Console.WriteLine("ERROR");
}