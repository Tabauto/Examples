// int x = 6; //целое число
// double y = 2.5; //дробное число
// //string str = "Привет"// Строка
// bool b = y > x; // Может принемать значение true (истина), или false (ложь)


// Console.WriteLine("Введите первое число");
// string strA = Console.ReadLine();
// int numberA = int.Parse(strA);
// Console.WriteLine("Введите второе число");
// string strB = Console.ReadLine();
// int numberB = int.Parse(strB);
// Console.WriteLine(numberA + numberB);

// // Ветвление if..else
// if (x == 5)
// {
//     Console.WriteLine("X Это пять");
// }
// else
// {
//     Console.WriteLine("X Это не пять");
// }
// //Console.WriteLine(b);

// Цикл
// int a = 0;
// while (a < 5)
// {
//   Console.WriteLine(a);
//   a++;   // увелечение на единицу
//   // а = а = 1;
//   // а += 1;
// }

// Задача
// Console.WriteLine("Введите число, мы возведем его в квадрат");
// string str = Console.ReadLine();
// int number = int.Parse(str);
// int square = number * number;
// Console.WriteLine("Квадрат вашего числа " + square);

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число");
string strA = Console.ReadLine();
int numberA = int.Parse(strA);
Console.WriteLine("Введите второе число");
string strB = Console.ReadLine();
int numberB = int.Parse(strB);
if (numberA == (numberB * numberB))
{
    Console.WriteLine("Первое является квадратом второго");
}
else
{
     Console.WriteLine("Первое  не является квадратом второго"); 
}
