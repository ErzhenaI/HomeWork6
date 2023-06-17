Console.Clear();
Console.Write("Введите 1-е значение прямой b1b2: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е значение прямой b1b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 1-е значение прямой k1k2: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е значение прямой k1k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (-(b1 - b2)) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"Точка пересечения двух прямых: [{x},{y}]");
