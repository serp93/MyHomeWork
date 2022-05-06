// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Degree()
{
Console.Write("Input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

{
if(b == 0) 
{
    Console.Write(1);    
}
    if (b == 1) 
        {
            Console.Write(a);
        }
        else
        {
            Console.WriteLine(a +", "+ b + "-> " + Math.Pow(a, b));   
        }
}
}
Degree();


// Задача 2
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]