//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

using static System.Console;

Clear();

Write("Введите число 1: ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число 2: ");
int num2 = Convert.ToInt32(ReadLine());
if(num1>num2)
{
    WriteLine($"Число {num1} больше числа {num2} ");
}
else
{
    WriteLine($"Число {num2} больше числа {num1} ");
}
