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

int[,] SwapFirstAndLastRows(int[,] array)
{
    int[] tmp = new int[array.GetLength(1)];

    for (int i = 0; i <= 0; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp[j] = array[i,j];
            array[i,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = tmp[j];
        }
    }
    return array;
}

Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк N: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
Console.WriteLine();

SwapFirstAndLastRows(array);
Console.WriteLine("Измененный массив");
PrintArray(array);
