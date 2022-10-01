// Заполняет массив случайными числами
int[] GetArrayFilled(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 1000);
    }

    return array;
}

// Выводит массив
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

// Считает числа от 10 до 99 включительно
int MatchCounter (int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = new int[123];

int[] arrayFilled = GetArrayFilled(array);
int counter = MatchCounter(arrayFilled);

PrintArray(arrayFilled);

Console.WriteLine($"В сгенерированном массиве {counter} чисел от 10 до 99.");
