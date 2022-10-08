/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
AB = √((X2 - X1)^2 + (Y2 - y1)2+(Z2 - z1)^2)
*/

void GetDistance(int firstX, int secondX, int firstY, int secondY, int firstZ,int secondZ)
{
double result = 0;
result = Math.Sqrt(Math.Pow(secondX-firstX,2)+Math.Pow(secondY-firstY,2)+ Math.Pow(secondZ-firstZ,2));
Console.WriteLine($"расстояние между двумя точками = {result}");
}

GetDistance(3,2,6,1,8,-7);