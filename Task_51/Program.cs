int[,] FillArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int GetSumOfPrimeDiagonal (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum+array[i,j];
            }
        }
    }
    return sum;
}

Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк N: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

FillArray(array);

PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Сумма чисел находящихся на главной диагонали равна " + GetSumOfPrimeDiagonal(array));

Console.ReadKey();
