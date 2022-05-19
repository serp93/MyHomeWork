// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// Console.Write("Input size of matrix: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] a = new double[n, m];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//     a[i,j] = Math.Round(new Random().NextDouble()*20-10, 1);
//     Console.Write(a[i,j] + "\t");
//     }
// Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// Console.Write("Input matrix height: ");
// int height = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input matrix width: ");
// int width = Convert.ToInt32(Console.ReadLine());
// int[,] arr = new int[height, width];

// Console.Write("Input row number of the matrix ");
// int k = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input number of matrix column: ");
// int l = Convert.ToInt32(Console.ReadLine()) - 1;
// for(int i = 0; i < arr.GetLength(0); i++)
// {
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = i + j;
//         Console.Write("{0} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }
// if(k < 0 | k > arr.GetLength(0) - 1 | l < 0 | l > arr.GetLength(1) - 1)
// {
// Console.WriteLine("there is no such number in the array");
// }
// else
// {
// Console.WriteLine("Value of the array element = {0}", arr[k, l]);
// }
// Console.ReadLine();


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.


// Console.Write("Input matrix height: ");
// int height = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input matrix width: ");
// int width = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// int[,] arr = new int[height, width];
// Console.WriteLine("Source array:");
// for(int i = 0; i < arr.GetLength(0); i++)
// {
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 11);
//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine("Arithmetic mean of each column:" );
// for(int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//         Console.Write($"{ sum / arr.GetLength(0)}; ");
// }
// Console.ReadLine();