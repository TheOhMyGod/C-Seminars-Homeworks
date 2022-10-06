int[] GetReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[result.Length - 1 - i];
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] GetReverseArray2 (int[] array)
{
    int tempStorage = array[0];
    for (int i = 0; i < (array.Length / 2); i++)
    {
        tempStorage = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - i - 1] = tempStorage;
    }
    return array;
}


int[] array = new int[] { 1, 2, 3, 4, 5 };
PrintArray(array);
int[] result = GetReverseArray(array);
int[] result2 = GetReverseArray2(array);


Console.WriteLine();
PrintArray(result);
Console.WriteLine();
PrintArray(result2);
