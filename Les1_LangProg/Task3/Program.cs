Console.Write("Insert numer day of week: ");
int d = Convert.ToInt32(Console.ReadLine());
// string result;
// if (d==1) result = "понедельник";
// else if (d==2) result = "вторник";
// else if (d==3) result = "среда";
// else if (d==4) result = "четверг";
// else if (d==5) result = "пятница";
// else if (d==6) result = "суббота";
// else if (d==7) result = "воскресенье";
// else result = "нет значения";
// Console.WriteLine(result);

switch (d)
{
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресенье");
        break;
    default:
        Console.WriteLine("нет значения");
        break;
}