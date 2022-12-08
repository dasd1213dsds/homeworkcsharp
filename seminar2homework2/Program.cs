//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num%10;
if (num < 99)
    Console.WriteLine("В этом числе нет третей цифры");
else
Console.WriteLine($"Третья цифра числа {num} является {num2}");