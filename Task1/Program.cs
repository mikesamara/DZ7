//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
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


