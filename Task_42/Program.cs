int GetTensToTwos (int number)
{
    int numberTens = 0;
    int rem = 0;
    int x = 1;
    while (number != 0)
    {
        rem = number % 2;
        numberTens = numberTens + rem*x;
        number = number / 2;
        x = x * 10;
    }
    return numberTens;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetTensToTwos(number));
