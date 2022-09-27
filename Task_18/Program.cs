// Определение диапазона по заданной четверти
string AreaNums(int x)
{
    if (x == 1)
    {
        return "В данной четверти всегда - x > 0, y > 0";
    }

    if (x == 2)
    {
        return "В данной четверти всегда - x < 0, y > 0";
    }

    if (x == 3)
    {
        return "В данной четверти всегда - x < 0, y < 0";
    }

    if (x == 4)
    {
        return "В данной четверти всегда - x > 0, y < 0";
    }

    return "Нет такой четверти!";
}

Console.Write("Введите название четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string result = AreaNums(x);
Console.Write(result);
