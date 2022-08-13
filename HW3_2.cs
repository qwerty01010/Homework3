Console.Clear();
Console.WriteLine ("Вычисление расстояния между точками");

Console.WriteLine ("Введите координату х первой точки:");
int x1 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите координату y первой точки:");
int y1 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите координату z первой точки:");
int z1 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите координату x второй точки:");
int x2 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите координату y второй точки:");
int y2 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Введите координату z второй точки:");
int z2 = int.Parse(Console.ReadLine ()!);

Console.WriteLine ("Координаты первой точки: " + x1 + ", "+ y1 + ", "+ z1 + "; Координаты второй точки: " + x2 + ", " + y2 + ", "+ z2);

double result = Math.Sqrt(((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1)));

Console.WriteLine("\n");
Console.WriteLine ("Расстояние между точками х и у = " + result.ToString("N2"));
