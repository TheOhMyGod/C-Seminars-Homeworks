// Нахождение расстояния между двумя точками на двухмерной плоскости
double GetDistance (int x1, int x2, int y1, int y2)
{
    double distant = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distant;
}

Console.WriteLine("Введите Координаты первой точки.");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Координаты второй точки.");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distant = GetDistance(x1, x2, y1, y2);
Console.WriteLine($"Расстояние между точками с координатами ({x1},{y1}) и ({x2}, {y2}) равно {Math.Round(distant, 2)}");
