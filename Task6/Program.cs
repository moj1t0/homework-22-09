//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

using static System.Console;

Clear();

Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
if(num1%2 == 0)
{
    WriteLine($"Число {num1} является четным ");
}
else
{
    WriteLine($"Число {num1} не является четным ");
}