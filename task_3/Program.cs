Console.WriteLine("Введите число и я проверю кратно ли оно 7 и 23: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp1 = number % 23;
int temp2 = number % 7;
if (temp1 + temp2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}