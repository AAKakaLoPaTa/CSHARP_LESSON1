Random intRandomValue = new Random();
int v3 = intRandomValue.Next(100, 1000);
// int a = v3 / 100;
// int b = v3 % 10;
// Console.WriteLine($"{v3} => {a}{b}");
Console.WriteLine($"{v3} => {v3/100}{v3%10}");