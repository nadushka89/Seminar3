﻿/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Point GetPoint()
{
Point point = new Point();
Console.WriteLine("Введите координату Х:");
point.X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату У:");
point.Y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z:");
point.Z = int.Parse(Console.ReadLine());
return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();

double result = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y,2)+ Math.Pow(firstPoint.Z - secondPoint.Z,2));
Console.WriteLine($"расстояние между двумя точками = {result}");
class Point
{
public int X { get; set;}
public int Y { get; set;}
public int Z { get; set;}
}
