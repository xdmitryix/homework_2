Console.Clear();
Console.WriteLine("введи число: ");
int number = int.Parse(Console.ReadLine());
int result = (number / 10) % 10;
Console.WriteLine("вторая цифра числа: " + result);