Console.WriteLine("Введите число от 1 до 7 согласно дню недели");
string number = Console.ReadLine();
int a = int.Parse(number);

if (a >= 6 && a <= 7)
{
    Console.WriteLine("Да, выходной день");
}
else if (a >= 8 || a <= 0)
{
    Console.WriteLine("Попробуй еще раз");
}
else
{
    Console.WriteLine("Нет, не выходной");
}