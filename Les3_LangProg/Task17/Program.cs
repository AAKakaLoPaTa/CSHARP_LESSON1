int Insert(string msg)
{
InsertDig: Console.Write($"Введите значение по {msg}: ");
    int dig = Convert.ToInt32(Console.ReadLine());
    if (dig == 0) { goto InsertDig; }
    return dig;
}
int Locate(int X, int Y)
{
    int loc = 0;
    if (X > 0 && Y > 0) { loc = 1; }
    else if (X > 0 && Y < 0) { loc = 4; }
    else if (X < 0 && Y < 0) { loc = 3; }
    else if (X < 0 && Y > 0) { loc = 2; }
    return loc;
}
int x = Insert("X");
int y = Insert("Y");
// int[] points = new int[2];
// for (int i = 0; i < points.Length; i++) {
// points[i] = Insert(i);
// }

Console.WriteLine(Locate(x, y));
