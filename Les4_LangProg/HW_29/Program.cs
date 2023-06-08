int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenArray(int count, int min, int max)
{
    int[] arr = new int[count];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.WriteLine($"Сгенерированный массив чисел -> [{String.Join(",", arr)}]");
}
PrintArray(GenArray(Insert("Введите количество элементов массива: "), 
Insert("Введите минимальное значение элемента массива: "), 
Insert("Введите максимальное значение элемента массива: ")));