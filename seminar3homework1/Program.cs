//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

System.Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
int num2 = num / 10000;
int num3 = num / 1000 % 10;
int num4 = num / 10 % 10;
int num5 = num % 10;
if (num > 9999 && num < 99999)
    if (num2 == num5 && num3 == num4)
        System.Console.WriteLine("Это число является палиндромом");
    else 
        System.Console.WriteLine("Это число не является палиндромом");
else
    System.Console.WriteLine("Это число не пятизначное");
