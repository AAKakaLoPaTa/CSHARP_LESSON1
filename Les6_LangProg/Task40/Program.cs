int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
string IsExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return "Треугольник существует";
    else return "Треугольник не существует";
}
int a = Insert("Введите длину первой стороны треугольника: ");
int b = Insert("Введите длину второй стороны треугольника: ");
int c = Insert("Введите длину третьей стороны треугольника: ");
Console.WriteLine(IsExist(a, b, c));