// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом (т.е. число должно быть одинаковым при чтении слева направо и
// справа налево).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.WriteLine("Введите пятизначное число");
// string strA = Console.ReadLine();
// int A = int.Parse(strA);
// int len = strA.Length;
// if ((len < 5) ^ (len > 5))
// {
//    Console.WriteLine("Число не пятизначное");
// }
// else if ((strA[0] == strA[4]) & (strA[1] == strA[3]))
// {
//    Console.WriteLine("Число палиндромное");
// }
// else
// {
//     Console.WriteLine("Число не палиндромное");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите первые координаты X,Y,Z");
int[] coorA = new int[3];
for (int i = 0; i < coorA.Length; i++)
{
    coorA[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Введите вторые координаты X,Y,Z");
int[] coorB = new int[3];
for (int i = 0; i < coorB.Length; i++)
{
    coorB[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Координаты первой точки ");
Console.WriteLine("X=" + coorA[0] + ", " + "Y=" + coorA[1] + ", " + "Z=" + coorA[2]);
Console.WriteLine("Координаты второй точки ");
Console.WriteLine("X=" + coorB[0] + ", " + "Y=" + coorB[1] + ", " + "Z=" + coorB[2]);
double distance = Math.Sqrt((Math.Pow(coorB[0] - coorA[0], 2)) + (Math.Pow(coorB[1] - coorA[1], 2))+ (Math.Pow(coorB[2] - coorA[2], 2)));
string distance2 = string.Format("{0:f2}", distance);
Console.WriteLine("Расстояние между точками " + distance2);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Введите число куба ");
// string strN = Console.ReadLine();
// int n = int.Parse(strN);
// Console.WriteLine("Куб числа " + n);
// for (int n3 = 1; n3 <= n; n3++)
// {
//     Console.WriteLine(n3 * n3 * n3);
// }
