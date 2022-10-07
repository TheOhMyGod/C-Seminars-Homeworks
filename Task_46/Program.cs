// Размерность массива (кол-во строк)
int m = 0;

// Размерность массива (кол-во строк)
int n = 0;

Console.Write("Введите кол-во строк M: ");
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некоректного формата (M)");
    return;
}
else
{
    m = numberM;
}


Console.Write("Введите кол-во столбцов N: ");
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некоректного формата (N)");
    return;
}
else
{
    n = numberN;
}

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
//       Console.Write($"{array[i,j]} ");
    }
//    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

Console.ReadKey();
