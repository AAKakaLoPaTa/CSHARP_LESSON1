Console.Write("Insert digit: ");
int a = Convert.ToInt32(Console.ReadLine());
bool c = false;
if (a % 7 == 0 && a % 23 == 0) c = true;
Console.Write($"{a} кратно 7 и 23 => {c}");
