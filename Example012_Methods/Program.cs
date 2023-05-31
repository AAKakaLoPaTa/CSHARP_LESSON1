// Type 1
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();
// Type 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Hello");

void Method21(string msg, string msg2)
{
    Console.WriteLine(msg + msg2);
}
Method21(msg: "Hello", msg2: " World!");
// Type 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
// // Type 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result += text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Qwert");
// Console.WriteLine(res);

// Type 4
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string res = Method4(10, "Qwert");
Console.WriteLine(res);
// _________________________________________________
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}");
    }
    Console.WriteLine();
}

// ___________________________________________________
string textOld = "- sdfsdf C c ";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(textOld, ' ', '|');
Console.WriteLine(newText);

//_____________________________________________ сортировка массива по возрастанию

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

//_____________________________________________ сортировка массива по убыванию

int[] arra = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray1(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort1(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray1(arra);
SelectionSort1(arra);
PrintArray1(arra);