//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using static System.Console;

Clear();

Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());

WriteLine(num1%2 == 0);