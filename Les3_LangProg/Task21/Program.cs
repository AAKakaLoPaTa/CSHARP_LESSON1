int[] Insert(int msg)
{
    int[] arr = new int[2];
    Console.Write($"Введите значение по Х точки {msg}: ");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите значение по Y точки {msg}: ");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    return arr;
}
double Dist(int[] point1, int[] point2)
{
    return Math.Round(Math.Sqrt( Math.Pow(point1[0]-point2[0],2)+Math.Pow(point1[1]-point2[1],2) ), 2);
}
int[] p1 = Insert(1);
int[] p2 = Insert(2);
Console.WriteLine($"Расстояние между точками {Dist(p1, p2)}");