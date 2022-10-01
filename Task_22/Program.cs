// Метод принимает число и создает массив с квадратами от 1 до введенного числа
double[] GetSquaresNumbers (int number)
{
    double[] squaresNumbers = new double[number];

    // Заполнение массива результата
    for (int i = 0; i < number; i++)
    {
        squaresNumbers[i] = Math.Pow(i + 1, 2);
    }

    return squaresNumbers;
}

Console.Write ("Введите число: ");
int num = int.Parse(Console.ReadLine());

double[] result = GetSquaresNumbers(num);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
