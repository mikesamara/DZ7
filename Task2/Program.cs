//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

System.Console.WriteLine("введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-100, 100); ;
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

if (n > arr.GetLength(0) || m > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {arr[n-1,m-1]}");
}