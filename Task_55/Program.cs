int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArrayTransposed (int[,] array)
{
    int[,] tmpArray = new int[array.GetLength(0),array.GetLength(1)];
    
    // транспонирование массива во временный массив
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmpArray[j,i] = array[i,j];
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = tmpArray[i,j];
        }
    }

    return array;
}


try
{
    Console.Write("Введите количество строк M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите количество строк N: ");
    int n = int.Parse(Console.ReadLine());
    
    int[,] array = new int[m, n];
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    GetArrayTransposed(array);
    PrintArray(array);
}

catch (System.Exception)
{
    Console.Write("Массив не квадратный! (Смотрите выше)"
    +" Необходимо задать одинаковые значения для строк и стобцов!");
}
