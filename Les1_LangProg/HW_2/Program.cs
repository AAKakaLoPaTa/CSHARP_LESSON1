Console.Write("Insert digit A: ");
string A = Console.ReadLine();
if (int.TryParse(A, out int C))
{
    Console.Write("Insert digit B: ");
    string B = Console.ReadLine();
    if (int.TryParse(B, out C))
    {

        if (Convert.ToInt32(A) == Convert.ToInt32(B)) Console.Write(String.Concat(A, " = ", B));
        else if (Convert.ToInt32(A) > Convert.ToInt32(B)) Console.Write(String.Concat("max = ", A, ", min = ", B));
        else Console.Write(String.Concat("max = ", B, ", min = ", A));
    }
    else Console.Write("Inserted text B is not digit");
}
else Console.Write("Inserted text A is not digit");