// Задача 19

// Console.Write("Введите пятизначное число: ");
//     string nstrba = Console.ReadLine();            
//     int n;
//     if (!int.TryParse(nstrba, out n))
//     {
//         Console.Write("Вы ввели не число");
//         Console.ReadKey();
//         return;
//     }
//     if (n < 10000 || n > 99999)
//     {
//         Console.Write("Введённое число не пятизначное");
//         Console.ReadKey();
//         return;
//     }
//     if (nstrba[0] != nstrba[4] && nstrba[1] != nstrba[3])
//         Console.WriteLine(false);
//         else
//         Console.WriteLine(true);
// Console.ReadKey();

// Задача21

// double Sqrt1(int x1, int y1, int x2, int y2, int z1, int z2)
// {
//     return Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2-z1)*(z2-z1));
// }
// Console.WriteLine("Введите через строчку координаты первой точки");
// int x1 =Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите через строчку координаты второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.Write(Sqrt1(x1, y1, x2, y2, z1, z2));

// Задача 23

// void cube(int N)
// {
//     int count = 1;
//     Console.Write (N + " -> ");
//  while(count <= N)
//     {
//         Console.Write (count*count*count + " ");
//         count++;
//     }
// }
// Console.Write("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine());
// cube(num);