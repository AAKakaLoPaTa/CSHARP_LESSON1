Random intRandomValue = new Random();
int a = intRandomValue.Next(10, 100);
int b = a / 10;
int c = a % 10;
int max;
if (b > c) { max = b; }
else { max = c; }
Console.WriteLine(String.Concat(a, " => ", max));
Console.WriteLine(a + " => " + max); // еще вариант отображения
Console.WriteLine("{0} => {1}", a, max); // еще вариант отображения
Console.WriteLine($"{a} => {max}"); // еще вариант отображения
