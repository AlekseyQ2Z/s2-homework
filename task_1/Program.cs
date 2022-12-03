Console.WriteLine("Введите трехзначное число и я напишу Вам его вторую цифру: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 99 && number1 < 1000)
{
    int number2 = number1 % 100 / 10;
    Console.WriteLine("Вторая цифра числа " + number1 + ": " + number2);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
