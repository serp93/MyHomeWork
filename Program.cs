// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, 
// начинающихся на гласную букву.


// // Console.Write("Введите строку: ");
// // string[] str = Console.ReadLine();


// string[] words = { "qwe", "wer", "ert", "rty", "tyu" };

// int Vowels(string[] array)
// {
//     string word = string.Empty;
//     char[] vowels = { 'A', 'E', 'Y', 'U', 'I', 'O', 'a', 'e', 'y', 'u', 'i', 'o' };
//     int glas = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         word = (array[i]);
//         for (int j = 0; j < vowels.Length; j++)
//         {
//             if (word[0] == vowels[j])
//             {
//                 glas++;
//             }
//         }
//     }
//     return glas;
// }
// Console.WriteLine(Vowels(words));



// Задача 2: Задайте массив строк. Напишите программу, 
// которая генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}


// // Console.Write("Введите строку: ");
// // string[] str = Console.ReadLine();

// string[] words = { "qwe", "wer", "ert", "rty", "tyu", "yui" };
// string[] Vowels(string[] array)
// {
//     for (int j = 0; j < array.Length;)
//     {
//         words[j] += words[j + 1];
//         j += 2;
//     }
//     return array;
// }

// void PrintArray(string[] array)
// {
//     Console.Write(words[0] + ", " + words[2] + ", " + words[4]);
// }

// PrintArray(Vowels(words));


