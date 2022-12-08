// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

// Console.WriteLine("Задайти колличество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайти колличество столбцов");
// int n = int.Parse(Console.ReadLine());
// double[,] arr = new double[m, n];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 2);
//     }
// }
// // // Вывод двумерного массива
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Задайти колличество строк");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Задайти колличество столбцов");
// int n = int.Parse(Console.ReadLine());
// double[,] arr = new double[m, n];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(1, 100);
//     }
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");
// Console.WriteLine("Введите число для поиска в массиве ");
// string strA = Console.ReadLine();
// int number = int.Parse(strA);
// Console.WriteLine(" ");
// int ind1 = 0,
//     ind2 = 0;
// int col = 0;
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)

//         if (arr[i, j] == number)
//         {
//             col++;
//             ind1 = i;
//             ind2 = j;
//             Console.WriteLine(
//                 $"Число {number} находится на сторке {ind1 + 1}, столбец {ind2 + 1} данного массива"
//             );
//         }
// }
// if (col == 0)
// {
//     Console.WriteLine($"Числа {number} нет среди Элементов массива");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задайти колличество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайти колличество столбцов");
int n = int.Parse(Console.ReadLine());
double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое столбца: ");
for(int i = 0; i < n; i++)
{
    double mid = 0;
    for(int x = 0; x < n; x++)
    {
        //Console.Write(arr[x, i] + " ");
        mid += arr[x, i];
    }
    mid = mid / n;
    Console.Write($"  {Math.Round(mid, 2)}  ");
}
