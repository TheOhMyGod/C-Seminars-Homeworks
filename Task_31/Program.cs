int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }

    return array;
}

int GetSumPositiveNumbers (int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int GetSumNegativeNumbers (int[] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

var array = GetArray(12, -9, 9);
int sumPositive = GetSumPositiveNumbers(array);
int sumNegative = GetSumNegativeNumbers(array);

Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел массива равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел массива равна {sumNegative}");