//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());
int a = (x2 - x1);
int b = (y2 - y1);
int c = (z2 - z1);
double range = Math.Sqrt((a * a) + (b * b) + (c * c));
Console.WriteLine(range);