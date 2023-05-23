// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindr (int number) {
// int temp = number;
// int reverse = 0;

// while (temp != 0)
// {
//     int remainder = temp % 10;
//     reverse = reverse * 10 + remainder;
//     temp /= 10;
// }

// if (number == reverse) return true;
// else return false;
// }

// System.Console.WriteLine("Введите 5-значное число");
// int number = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Число {number} является палиндромом -> {Palindr(number)}");

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка {segmentLength}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cube (int n) {
//     int i = 1;
//     while (i <= n) {
//         System.Console.WriteLine($"{i} -> {i * i * i}");
//         i++;
//     }
    
// }

// System.Console.WriteLine("Input number");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"The cube from 1 to {n} is: ");
// Cube(n);