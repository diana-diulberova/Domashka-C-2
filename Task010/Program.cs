/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99 || number > 999) 
{
    Console.WriteLine("Введено неправильное число");
}
else 
{
    int number2 = number / 10 % 10;
Console.WriteLine(number2);
}