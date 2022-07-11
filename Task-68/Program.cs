// Решение только через рекурсию!
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;
using static System.Console;
Clear();

Write("Введите М: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());

if (m < 0 || n < 0) WriteLine("Вы ввели отрицательное число");
else WriteLine($"{AckermannFunction(n, m)}");

int AckermannFunction(int numberOne, int numberTwo)
{
   if (numberOne == 0)
      return numberTwo + 1;
   else
    if ((numberOne != 0) && (numberTwo == 0))
      return AckermannFunction(numberOne - 1, 1);
   else
      return AckermannFunction(numberOne - 1, AckermannFunction(numberOne, numberTwo - 1));
}