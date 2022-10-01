// Создает массив со случайным набором натуральных чисел.
// Длина массива, и интервал случайных чисел задается пользователем в коде.
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

// Заменяет положительные элементы массива соответствующими отрицательными.
int[] GetNumbersMirrored (int[] array)
{
    var arrayMirrored = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayMirrored[i] = array[i] * -1;
    }

    return arrayMirrored;
}

var array = GetArray(20, -10, 10);
var arrayMirrored = GetNumbersMirrored(array);

Console.Write("Массив: ");
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Отзеркаленный массив:");
for (int i = 0; i < arrayMirrored.Length; i++)
{
    Console.Write($"{arrayMirrored[i]} ");
}
