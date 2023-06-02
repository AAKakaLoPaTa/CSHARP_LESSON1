int[] Array(int c)
{
    int[] arr = new int[c];
    Random rnd = new Random();
    for (int i = 0; i < c; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(",", arr));
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     if (i == 0) { Console.Write("["); }
    //     Console.Write(arr[i]);
    //     if (i < arr.Length - 1) { Console.Write(","); }
    //     if (i == arr.Length - 1) { Console.Write("]"); }
        
    // }
}
Print(Array(8));
