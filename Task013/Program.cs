/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99 ) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int devision = number / 100;
    int index = 0;
    while (devision > 1)
    {
        index++;
        devision = devision / 10;
    }
    int thirdDigital = 0;
    if(index > 1)
    {
        int degree = 10;
        int i = 1;
        while(i < index)
        {
            thirdDigital = number / degree % 10;
            degree = degree * 10;
            i++;
        }
    }
    else
    {
        thirdDigital = number % 10;
    }

    Console.WriteLine($"Третьей цифрой числа {number} является {thirdDigital}");

}