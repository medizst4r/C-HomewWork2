/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 100 / 10;
Console.WriteLine (result);
*/


/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 99)
{
   Console.WriteLine("Третьей цифры нет");
}
    
    while  (num >1000)
    if (num >1000)
    {
        num = num / 10;
    }
    else
    {
        num = num %10;
    }
    Console.WriteLine(num % 10);
    
*/
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool DayNum(int number);
{
    if (number == 6 || 7)
    {
        return true;
    }
    else
    {
        return false;
    }
    
}
Console.WriteLine("Input a day week: ");
int num =Convert.ToInt32(Console.ReadLine());


bool result = DayNum(num);
Console.WriteLine(result);
