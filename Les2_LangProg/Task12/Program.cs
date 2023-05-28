Console.Write("Insert digit A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert digit B: ");
int b = Convert.ToInt32(Console.ReadLine());
if ((a % b) == 0) Console.Write($"{a} кратно {b}");
else Console.Write($"{a} не кратно {b} => остаток {a % b}");