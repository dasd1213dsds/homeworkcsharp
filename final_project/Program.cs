﻿//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int num1 = num;
int x = 1;
while (x < num)
{
    x++;
    num1--;
    System.Console.Write($"{num1}, ");
    
}