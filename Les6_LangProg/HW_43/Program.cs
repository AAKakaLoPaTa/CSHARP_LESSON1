// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
double[] Peres(double b1, double k1, double b2, double k2)
{
    double[] array = new double[3];
    array[0] = (b1 - b2) / (k2 - k1);
    array[1] = k1 * array[0] + b1;
    array[2] = k2 * array[0] + b2;
    return array;
}
// Не учел возможность параллельности прямых - проверять равность двух уравнений нужно!
double b1 = Insert("Введите b1: ");
double k1 = Insert("Введите k1: ");
double b2 = Insert("Введите b2: ");
double k2 = Insert("Введите k2: ");
double[] p = Peres(b1, k1, b2, k2);
if (k1 == k2) {
    if (b1 == b2) Console.WriteLine($"Прямые совпадают");
    else Console.WriteLine($"Прямые параллельны");
    }
else {Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({p[0]}; {p[1]})");}