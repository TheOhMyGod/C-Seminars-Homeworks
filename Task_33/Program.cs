// Выводит "Да" или "Нет" в зависимости есть ли число в массиве или нет
string GetApperanceOfNumber (int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            return "Да";
        }
    }
    return "Нет";
}

int[] array = new int[5] { 6, 7, 19, 345, 3 };

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

string answer = GetApperanceOfNumber(array, n);

if (answer == "Да")
{
   Console.WriteLine($"{answer}! Введенное число есть в массиве."); 
}
else Console.WriteLine($"{answer}! Введенного числа нет в массиве.");

Console.WriteLine(GetApperanceOfNumber(array, n));
