// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4]; // 4 - размер (количество) create an array
// int positiveNumber = 0;
// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(100, 1000); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // ищем колличество четных чисел
// {
//     if (array[i] % 2 == 0)
//     {
//         positiveNumber++;
//     }
// }

// Console.WriteLine(positiveNumber);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4]; // 4 - размер (количество) create an array
// int sum = 0;
// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(-99, 100); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// for (int i = 1; i < array.Length; i+=2) // ищем колличество четных чисел
// {

//         sum += array[i];

// }
// Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] array = new double[5]; // 4 - размер (количество) create an array
// int minArray = -99;
// int maxArray = 100;
// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     double randomNumber = new Random().Next(minArray, maxArray) + new Random().NextDouble(); // + NextDouble(); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(Math.Round(array[i], 2) + "   ");
// }
// Console.WriteLine(" ");
// double difference = Math.Round((array.Max() - array.Min()), 2);
// Console.WriteLine("Разницу между максимальным и минимальным элементов массива:  " + difference);

// Дополнительно. Задания 3, 4 необязательные
// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(100, 1000); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + "  ");
// }
// Console.WriteLine("");
// Console.WriteLine("Введите число для поиска в массиве ");
// string strA = Console.ReadLine();
// int number = int.Parse(strA);
// int pos = -1;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         pos = i;
//         break;
//     }
// }
// if (pos >= 0)
//     Console.WriteLine($"Число {number} находится на позиции {pos + 1} данного массива");
// else
//     Console.WriteLine($"Числа {number} нет среди Элементов массива");


// Задача 4: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] array = new int[12];
for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(1, 200); // генерируем случайное число
    array[i] = randomNumber; // кладём в массив на место с индексом i
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "  ");
}
Console.WriteLine("");
int arrElement = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] >= 10) & (array[i] <= 99))
    {
        arrElement++;
    }
}
if (arrElement >= 0)
    Console.WriteLine($"Колличество Элементов {arrElement} в отрезке от 10 до 99");
else
    Console.WriteLine($"Числа в отрезке от 10 до 99 нет среди Элементов массива");
