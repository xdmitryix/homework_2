Console.Clear();
Console.WriteLine("введи номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if ((number < 1) ^ (number > 7)) //добавил проверку существования дня недели
{
    Console.WriteLine("нет такого дня недели");
}
else
{
    if ((number >= 1) & (number <= 5))
    {
        Console.WriteLine("нет");
    }
    else
    {
        Console.WriteLine("да");
    }
}