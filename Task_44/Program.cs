// Создает массив и вставляет в него числа Фибоначи
double[] GetFibonacciNums(int number)
{
    double[] array = new double[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

// Выводит массив
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество первых чисел Фибоначчи, которые хотите получить: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Числа Фибоначчи: ");
PrintArray(GetFibonacciNums(number));
