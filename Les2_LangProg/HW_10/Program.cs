Console.Write("Insert 3-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000) Console.WriteLine($"{a} => {(a%100)/10}");
else Console.WriteLine("Number is not 3-digit");
