// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int first = number % 100;
// int second = first / 10;

// Console.WriteLine("Числа: " + second);

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = int.Parse(number);
int first = a % 100;
int second = first / 10;

Console.WriteLine("Число " + second);
