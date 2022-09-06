/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99 ) 
{
    Console.WriteLine("Третьей цифры нет");
}

if (number > 999) 
{
    Console.WriteLine("Введено неправильное число");
}

else 
{
    int number2 = number%10;
Console.WriteLine(number2);
}