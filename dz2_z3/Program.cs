Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("выходной день");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("нет такого дня недели");
    }
    else Console.WriteLine("невыходной день");
}

CheckingTheDayOfTheWeek(dayNumber);
