// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1=");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1=");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1=");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("x2=");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2=");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2=");
int z2 = int.Parse(Console.ReadLine());

double n = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками = {n:f3}");
