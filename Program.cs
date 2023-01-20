// Задача 47 Задайте двумерный массив размером m*n,заполненый случайными вещественными числами.
double[,] array = new double[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().NextDouble();
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}
