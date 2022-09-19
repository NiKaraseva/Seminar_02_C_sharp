/* Программа, которая принимает на вход два числа и выводит, 
является ли второе число кратным первому. Если второе число не кратно числу первому, 
то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int num3 = num2 % num1;

if (num3 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine ($"Второе число не кратно первому, остаток от деления = {num3}");
}
