Console.Clear();
Console.WriteLine("введи число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
int result = number % 10;
Console.WriteLine("третья цифра числа: " + result);
}
