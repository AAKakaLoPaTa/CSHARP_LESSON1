// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Insert(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}
int[] InsertArray(int q)
{
    int[] array = new int[q];
    for (int i = 0; i < q; i++)
    {
        array[i] = Insert($"Введите число № {i+1}: ");
    }
    return array;
}
int countInArray(int[] array)
{
    int tik = 0;
    foreach (var item in array)
    {
        if (item > 0) tik++;
    }
    return tik;
}

int count = Insert("Введите количество вводимых чисел: ");
int[] array = InsertArray(count);
int countInArr = countInArray(array);
Console.WriteLine($"[{String.Join(",", array)}] -> {countInArr}");