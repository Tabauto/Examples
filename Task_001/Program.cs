﻿//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("Введите первое число");
// string strA = Console.ReadLine();
// int numberA = int.Parse(strA);
// Console.WriteLine("Введите второе число");
// string strB = Console.ReadLine();
// int numberB = int.Parse(strB);
// if (numberA == (numberB * numberB))
// {
//     Console.WriteLine("Первое является квадратом второго");
// }
// else
// {
//      Console.WriteLine("Первое не является квадратом второго"); 
// }

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.WriteLine("Введите Ваша число");
// string strA = Console.ReadLine();
// int numberA = int.Parse(strA);
// int a = (numberA - (numberA * 2));
// while (a < (numberA + 1))
// {
//   Console.WriteLine(a);
//   a++;   // увелечение на единицу
//   // а = а = 1;
//   // а += 1;
// }

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число");
// string strA = Console.ReadLine();
// int numberA = int.Parse(strA);
// Console.WriteLine("Введите второе число");
// string strB = Console.ReadLine();
// int numberB = int.Parse(strB);
// if (numberA > numberB)
// {
//     Console.WriteLine("Первое число больше второго");
// }
// else
// {
//      Console.WriteLine("Первое число меньше второго"); 
// }


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
string strA = Console.ReadLine();
int A = int.Parse(strA);
Console.WriteLine("Введите второе число");
string strB = Console.ReadLine();
int B = int.Parse(strB);
Console.WriteLine("Введите третье число");
string strС = Console.ReadLine();
int C = int.Parse(strС);
int[] ABC = {A, B, C};
int max = ABC[0];
if (ABC[1] > max)
{
   max = ABC[1];
}
if (ABC[2] > max)
{
    max = ABC[2];
}
Console.WriteLine("Максимальное число " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");
// string str = Console.ReadLine();
// int number = int.Parse(str);
// if (number % 2 == 0)
//  {
//    Console.WriteLine("Чесло является четным"); 
//  }
//  else
//  {
//     Console.WriteLine("Число не четное"); 
//  }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число ");
// string str = Console.ReadLine();
// int number = int.Parse(str);
// Console.WriteLine("Четные числа от 1 до " + number);
// int a = (2);
// while (a < number)
// {
//   Console.WriteLine(a);
//   a += 2;
// }
// Перенос в задачи