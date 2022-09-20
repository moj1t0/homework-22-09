//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;

Clear();

Write("Введите число 1: ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число 2: ");
int num2 = Convert.ToInt32(ReadLine());
Write("Введите число 3: ");
int num3 = Convert.ToInt32(ReadLine());
if(num1>num2 & num1>num3)
{
    WriteLine($"Число {num1} больше числа {num2} и {num3} ");
if(num2>num1 & num2>num3)
{
    WriteLine($"Число {num2} больше числа {num1} и {num3} ");
}
}
else 
{
    WriteLine($"Число {num3} больше числа {num1} и {num2} ");
}