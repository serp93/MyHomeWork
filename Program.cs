// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }

// void Remains(int[] array)
// {
//         int a = 0;
        
//         for(int i = 0; i < array.Length; i++)
//         {
//             if(array[i] % 2 ==0)
//             a++;  
//         }
//         Console.WriteLine("-> " + a);
// }

// int[] myArray = CreateRandomArray(4, 100, 999);
// ShowArray(myArray);
// Remains(myArray);

// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }
// void SumOod(int[] array)
// {
//         int sum = 0;
//         for(int i = 0; i < array.Length; i++)
//         {
//             if(array[i] % 2 != 0)
//             sum = sum + array[i];
//         }
//         Console.WriteLine("-> " + sum);
// }

// int[] myArray = CreateRandomArray(4, 0, 99);
// ShowArray(myArray);
// SumOod(myArray);

// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// double[] CreateRandomArray(int size, int min, int max)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }
// void ShowArray(double [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }
// void DifferenceMinMax(double [] array)
// {
//         double max = 0;
//         double min = 0;
//         double a = 0;
//         for(int i = 0; i < array.Length; i++)
//         {
//             if(array[i] > max)
//             max = array[i];
//             else 
//             min = array[i];    
              
//         }
//         a = max - min;
//         Console.WriteLine("-> " + a);
// }

// double[] myArray = CreateRandomArray(5, 0, 99);
// ShowArray(myArray);
// DifferenceMinMax(myArray);

