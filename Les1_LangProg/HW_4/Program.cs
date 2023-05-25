Console.Write("Insert digit A: ");
string A = Console.ReadLine();
int dA, dB, dC;
if (int.TryParse(A, out dA))
{
    Console.Write("Insert digit B: ");
    string B = Console.ReadLine();
    if (int.TryParse(B, out dB))
    {
        Console.Write("Insert digit C: ");
        string C = Console.ReadLine();
        if (int.TryParse(C, out dC))
        {
            int max;
            if (dA > dB) max = dA;
            else max = dB;
            if (max < dC) max = dC;
            Console.Write(String.Concat("max = ", max));
        }
        else Console.Write("Inserted text C is not digit");
    }
    else Console.Write("Inserted text B is not digit");
}
else Console.Write("Inserted text A is not digit");