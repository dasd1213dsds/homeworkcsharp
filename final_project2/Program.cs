//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int begin = 1;
int end = 15;
int sum = 0;
for (; begin < end; begin++ )
{
    sum = sum + begin;
}
System.Console.WriteLine(sum + end);
