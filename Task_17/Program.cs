// Определение четверти точки
int GetPointArea(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }

    return 0;
}

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

int areaNum = GetPointArea(x, y);
Console.WriteLine($"Четерть заданной точки - {areaNum}");
