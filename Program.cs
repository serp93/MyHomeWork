// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.


// void Degree()
// {
// Console.Write("Input first integer number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second integer number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int n = 1;
// {
// for(int i = 0; i <= b; i++) 
//     {
//     n *= a;
//     }
// }
// Console.WriteLine(a+", " + b + " -> " + n); 
// }
// Degree();


// Задача 2
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.


// int SumNumber(int num)
// {
// int sum = 0;
// int temp = num;
//     while (temp > 0)  
//     {
//         sum += temp % 10; 
//         temp /=10;
//     }
//     return sum;
// }
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n + " -> " + SumNumber(n));


// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int[] NewArray;
// Console.Write("n= ");
// int n = int.Parse(Console.ReadLine());
// NewArray = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write("A[{0}]= ", i);
//     NewArray[i] = int.Parse(Console.ReadLine());
// }
// foreach (int elem in NewArray) 
//  Console.Write("{0} ", elem);
//  Console.ReadKey();
