//Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними
//  в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату первого числа, ось X: ");
double Ax = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату первого числа, ось Y: ");
double Ay = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату первого числа, ось Z: ");
double Az = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координату второго числа, ось X: ");
double Bx = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату второго числа, ось Y: ");
double By = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату второго числа, ось Z: ");
double Bz = Convert.ToDouble(Console.ReadLine()!);

double C = Math.Pow((Ax - Bx), 2) + 
Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2);
double R = Math.Sqrt(C);

Console.WriteLine($"Расстояние между точками в 3D пространстве {R:f2}");