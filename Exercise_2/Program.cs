/* Программа, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа*/

int number = new Random().Next(100, 1000);


int num1 = number / 100;
int num2 = number % 10;
int num3 = num1 * 10 + num2;
Console.WriteLine($"Первая и вторая цифры числа {number} = {num3}");
