Console.Write("Введите количество строк M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов N:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = i + j;
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

Console.ReadKey();
