//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9



int[,] GetArray(int m, int n, int minValue, int maxValue);
{
    int[,] res =  new int[m,n];
    for (int x = 0; x<m; x++)
    {
        for (int x1 = 0; x1<n; x1++)
        {
            res[x,x1] = new Random().Next(minValue,maxValue);
        }
    }
    return res;
}
void PrintArray(int[,] inArray)
{
    for (int x = 0; x<inArray.GetLength(0); x++)
    {
        for (int x1 = 0; x1<inArray.GetLength(1); x1++)
        {
            System.Console.WriteLine($"{res[x,x1]}");
        }
    }
    return res;
}
System.Console.WriteLine("Введите кол-во столбцов");
int col = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите кол-во строк");
int row = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(col,row, -5, 5);
PrintArray(array);

