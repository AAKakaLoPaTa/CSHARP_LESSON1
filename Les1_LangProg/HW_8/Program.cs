Console.Write("Insert digit: ");
string s = Console.ReadLine();
if (int.TryParse(s, out int d))
{
    if (d < 2) {Console.Write("В диапазоне нет значений");}
    else
    {
        if (d % 2 != 0) {d = d - 1;}
        for (int i = 2; i <= d; i+=2) {
            if (i == 2)
            {
                Console.Write("\"");
            }
            if (i != 2)
            {
                Console.Write(", ");
            }
            Console.Write(i);
            if (i == d)
            {
                Console.WriteLine("\"");
            }
        }
    }
}
else { Console.Write("Not digit!"); }





