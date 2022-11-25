// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine());
// int sum = numberA;
// for (int i = 1; i < numberB; i++)
// {
//     sum = sum * numberA;
// }
// Console.WriteLine("Число " + numberA + " в степени " + numberB);
// Console.WriteLine(sum);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summ = 0;
// while (n != 0)
// {
//     summ = summ + n % 10;
//     n = n / 10;
// }
// Console.WriteLine("Сумма чисел равна: {0}", summ);


// Задача 29: Напишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]
// int massLenght = 8;
// int[] mass = new int[massLenght];

// for (int i = 0; i < massLenght; i++)
// {
//     mass[i] = new Random().Next(0, 20);
// }
// Console.WriteLine();
// Console.Write("Вывод массива из " + mass.Length + " элементов: [");
// for (int i = 0; i < massLenght - 1; i++)
// Console.Write(mass[i] + ", ");
// Console.Write(mass[massLenght -1] + "]");
