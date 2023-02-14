//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
System.Console.WriteLine("введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(10); ;
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = (sum + arr[i, j]);
    }
    sum = sum / n;
    Console.Write(sum + "; ");
}

