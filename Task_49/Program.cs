int[,] GetEvenElementsDoubled(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

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

Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк N: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

FillArray(array);

PrintArray(array);

GetEvenElementsDoubled(array);
Console.WriteLine();

PrintArray(array);