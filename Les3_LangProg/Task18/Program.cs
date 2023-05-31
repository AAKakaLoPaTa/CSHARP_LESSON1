Inser: Console.Write("Введите четверть: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c > 0 && c < 5)
{
    string s = "";
    if (c == 1) { s = "X>0,Y>0"; }
    else if (c == 2) { s = "X<0,Y>0"; }
    else if (c == 3) { s = "X<0,Y<0"; }
    else if (c == 4) { s = "X>0,Y<0"; }
    Console.WriteLine(s);
}
else { goto Inser; }