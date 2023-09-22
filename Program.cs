/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/

Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine("Первое число больше, чем второе");
else Console.WriteLine("Первое число меньше, чем второе");

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

// Console.Clear();

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b)
// {
//     if (a > c) Console.WriteLine($"Максимальное число: {a}");
//     else Console.WriteLine($"Максимальное число: {c}");
// }
// else if (b > a)
// {
//     if (b > c) Console.WriteLine($"Максимальное число: {b}");
//     else Console.WriteLine($"Максимальное число: {c}");
// }

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

// Console.Clear();

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 2 == 0) Console.WriteLine("Число четное");
// else Console.WriteLine("Число нечетное");

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

// Console.Clear();

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// // Вариант 1.

// for (int i = 0; i <= N; i++)
// {
//     if (i % 2 == 0) Console.Write(i + " ");
// }

// Вариант 2.

// int i = 2;

// while (i <= N)
// {
//     Console.Write(i + " ");
//     i += 2;
// }