﻿/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 0 || day > 7) Console.WriteLine("Введено неправильное число");
else if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5) Console.WriteLine("Нет");
else if (day == 6 || day == 7) Console.WriteLine("Да");