// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Write("Вводите число Элементов которое хотите ввести: ");
// int n = int.Parse(Console.ReadLine());
// int[] array = new int[n];
// Console.Write("Вводите числа: ");
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Введите {0}-й элемент", i + 1);
//     array[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine("");
// int arrElement = 0;
// for (int i = 0; i < n; i++)
// {
//     if (array[i] > 0)
//     {
//         arrElement++;
//     }
// }
// if (arrElement > 0)
//     Console.WriteLine($"Колличество Элементов больше 0 : {arrElement}");
// else
//     Console.WriteLine($"Числа больше 0 нет, среди введенных чисел");   
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Задайте значение b1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение b2");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение k2");
double k2 = int.Parse(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"Точка пересечения ({y1}; {y2})");