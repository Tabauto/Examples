// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите трехзначное число");
// string strA = Console.ReadLine();
// int A = int.Parse(strA);
// int len = strA.Length;
// if ((len - 3) == 0)
// {
//     int two = ((A / 10) % 10);
//     Console.WriteLine("Второе цифра " + two);
// }
// else
// {
//     Console.WriteLine("Это не трехзначное число");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите трехзначное число");
// string strA = Console.ReadLine();
// int A = int.Parse(strA);
// int len = strA.Length;
// if (len >= 3)
// {
//     char number3 = strA[2];
//     Console.WriteLine("Третья цифра " + number3);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели ");
string strA = Console.ReadLine();
int weekday = int.Parse(strA);
switch (weekday)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Ура выходной Суббота");
        break;
    case 7:
        Console.WriteLine("Ура выходной Воскресенье");
        break;
 default:
        Console.WriteLine("Этого дня нет");
        break;
}
