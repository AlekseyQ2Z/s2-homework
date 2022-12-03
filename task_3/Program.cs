Console.WriteLine("Введите число и я проверю кратно ли оно 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number % 23 % 7;
if (number == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}