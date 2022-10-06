
// Проверяет теорему о неравенстве треугольника (каждая сторона треугольника меньше суммы двух других)
void GetPosibility(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} может существовать");
    }

    else
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существовать не может");
    }
}

Console.Write("Введите длину стороны A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны C: ");
int c = Convert.ToInt32(Console.ReadLine());

GetPosibility(a, b, c);
