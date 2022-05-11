
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input " + i + " element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + "," + " ");
// }

// void SumOfElements(int[] array)
// {
//         int Sum = 0;
//         for(int i = 0; i < array.Length; i++)
//         {
//             if(array[i] > 0)
//                 Sum += 1;
//         }
//         Console.WriteLine(" -> " + Sum);
// }

// int[] myArray = CreateArray(5);
// ShowArray (myArray);
// SumOfElements (myArray);



// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.


// void Binary(string[] args)
//     {
//     Console.Write("Input number: ");
//     int temp = Convert.ToInt32(Console.ReadLine());
//     int temp1;
//     string result = string.Empty;
//     while (temp > 0)
//         {
//             temp1 = temp % 2;
//             temp /= 2;
//             result = temp1.ToString() + result;
//         }
//     Console.Write("-> {0}",result);
//     }
// Binary (args);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


int IsTriangleExist(int b1, int k1, int b2, int k2, int x, int y)
{
Console.WriteLine("-> " + x + ": ");
int Z = Convert.ToInt32(Console.ReadLine());
return Z;
}    

Console.WriteLine("Введите через строчку b1, k1");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите через строчку b2, k2");
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

    int x = (b2 - b1) / (k1 - k2);
    int y = k1 * x + b1;

Console.WriteLine("point of across! x:" + x + "   y:"+ y); 
Console.Write(IsTriangleExist(b1, k1, b2, k2, x, y));    






