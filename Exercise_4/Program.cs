/* Программа, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23*/

Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

/*if ((num1 % 7 == 0) && (num1 % 23 == 0)) // первый вариант
{
    Console.WriteLine("Число делится на 7 и на 23");
}
else
{
    Console.WriteLine("Число НЕ делится на 7 и на 23 одновременно");
}*/

if ((num1 % 7 != 0) || (num1 % 23 != 0)) // второй вариант 
{
    Console.WriteLine("Не делится");
}
else
{
    Console.WriteLine("Число делится на 7 и на 23 одновременно");
}
