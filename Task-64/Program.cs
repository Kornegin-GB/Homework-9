// Решение только через рекурсию!
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

Write("Введите М: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());

WriteLine($"{MultiplicatNaturalNumbers(m, n)}");

int MultiplicatNaturalNumbers(int numberOne, int numberTwo)
{
   if (numberTwo > numberOne) return numberOne * MultiplicatNaturalNumbers(numberOne + 1, numberTwo);
   return numberOne;
}