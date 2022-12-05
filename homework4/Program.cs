//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int num2 = 2;
while (num2 < num)
{
    Console.WriteLine(num2);
    num2++;
    num2++;
}
Console.WriteLine(num2);