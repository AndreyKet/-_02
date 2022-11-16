Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = int.Parse(number);

if (a >= 100)
{
    while (a > 999)
    {
        a = a / 10;
    }
    int third = a % 10;
    Console.WriteLine("Третье число " + third);
}   
else
{
Console.WriteLine("Третьего числа нет");
}    