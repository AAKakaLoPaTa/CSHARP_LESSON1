double Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
double[] Peres(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b1 - b2) / (k2 - k1);
    array[1] = k1 * array[0] + b1;
    return array;
}

double b1 = Insert("Введите b1: ");
double k1 = Insert("Введите k1: ");
double b2 = Insert("Введите b2: ");
double k2 = Insert("Введите k2: ");
double[] p = Peres(b1, k1, b2, k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({p[0]}; {p[1]})");