// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("---------------------------");
// Console.WriteLine("sorted matrix: " );

// int[] row = new int[width];
// for (int i = 0; i < height; i++)
// {
//     for (int j = 0; j < width; j++)

//         row[j] = arr[i, j];
//         BubbleSort(row);
//         Insert(true, i, row, arr);

// }
// Print(arr);

// void Insert(bool isRow, int dim, int[] source, int[,] dest)
//         {
//             for (int k = 0; k < source.Length; k++)
//             {
//                 if (isRow)
//                     dest[dim, k] = source[k];
//                 else
//                     dest[k, dim] = source[k];
//             }
//         }
// void Print(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     Console.Write(array[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
// void BubbleSort(int[] b)
// {
//     for(int i = 0; i < b.Length; i++)
//         for(int j = 0; j < b.Length- i - 1; j++)
//     {
//             if (b[j] > b[j + 1])
//         {
//             int temp = b[j];
//             b[j] = b[j + 1];
//             b[j + 1] = temp;
//         }
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[][] arr;
// Console.Write("Input matrix height: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input matrix width: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// arr = new int[n][];
// int[] sum = new int[n];
// Console.WriteLine("Source array:");
// for(int i = 0; i < n; i++)
// {
//     arr[i] = new int[n];
//     for(int j = 0; j < m; j++)
//     {
//         arr[i] [j] = random.Next(1, 10);
//         Console.Write(arr[i][j] + "\t");
//         sum[i] += arr[i][j];
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("---------------------------");

// int min = Array.IndexOf(sum, sum.Min());

// Console.Write("Наименьшая сумма элементов массива в строке {0} \n ", min);
//             for (int j = 0; j < m; j++)
//             {
//                 Console.Write(" {0} ", arr[min] [j]);
//             }
//                 Console.ReadLine();


// Задача 62. Заполните спирально массив 4 на 4.


// Console.Write("Input matrix height: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input matrix width: ");
// int M = Convert.ToInt32(Console.ReadLine());
// var a = SpiralArrayVsClock(N, M);

// for (int i = 0; i < N; i++)
// {
//     for (int j = 0; j < M; j++)
//     {
//         Console.Write(a[i, j] + "\t");
//     }
//     Console.WriteLine();
// }


// int[,] SpiralArrayVsClock(int n, int m)
// {
//     var arr = SpiralArray(n, m);
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n / 2; j++)
//         {
//             var tmp = arr[i, j];
//             arr[i, j] = arr[i, m - j - 1];
//             arr[i, m - j - 1] = tmp;
//         }
//     }
//     return arr;
// }

// int[,] SpiralArray(int n, int m)
// {
//     int[,] A = new int[n, m];
//     int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

//     for (int i = 0; i < A.Length; i++)
//     {
//         A[col, row] = i + 1;
//         if (--gran == 0)
//         {
//             gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//             int temp = dx;
//             dx = -dy;
//             dy = temp;
//             dirChanges++;
//         }
//         col += dx;
//         row += dy;
//     }
//     return A;
// }

