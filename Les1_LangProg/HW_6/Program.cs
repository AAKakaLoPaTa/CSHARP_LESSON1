Console.Write("Insert digit: ");
string A = Console.ReadLine();
int dA;
if (int.TryParse(A, out dA))
{
    Console.Write((dA % 2)==0);
}
else Console.Write("Inserted text is not digit");