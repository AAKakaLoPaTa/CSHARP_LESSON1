Console.Write("Insert digit A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert digit B: ");
int b = Convert.ToInt32(Console.ReadLine());
bool c = false;
if (a * a == b || b * b == a) c = true;
Console.Write($"{a}, {b} => {c}");
