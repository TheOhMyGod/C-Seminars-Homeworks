// Заполняет массив случайными числами
int[] FillArray (int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }

    return array;
}

// Выводит массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] GetArraysCopy(int[] array)
{
    int[] arrayCopy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }

    return arrayCopy;
}


Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

Console.WriteLine("Сгенерированный массив: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Скопированный массив: ");
PrintArray(GetArraysCopy(array));
