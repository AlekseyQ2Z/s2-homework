Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine("Третья цифра: " + number);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
