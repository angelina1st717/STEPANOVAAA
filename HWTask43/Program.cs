﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Для уравнения y = k1 * x + b1 введите: ");
System.Console.Write("b1: ");
double b1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Для уравнения y = k1 * x + b1 введите: ");
System.Console.Write("k1: ");
double k1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Для уравнения y = k2 * x + b2 введите: ");
System.Console.Write("b2: ");
double b2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Для уравнения y = k2 * x + b2 введите: ");
System.Console.Write("k2: ");
double k2 = Convert.ToInt32(System.Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x * b1;
System.Console.WriteLine("->" + (x, y));