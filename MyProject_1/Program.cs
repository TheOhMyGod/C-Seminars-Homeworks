// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго


// Определение входных чисел
Console.Write ("Введите число 1: ");
int number_1 = int.Parse (Console.ReadLine());

Console.Write ("Введите число 2: ");
int number_2 = int.Parse (Console.ReadLine());

// Получение квадрата входного числа 2
int result = number_2 * number_2;

if (result == number_1)
{
    Console.WriteLine ($"Число {number_1} является квадратом числа {number_2}");
}
else
{
     Console.WriteLine ($"Число {number_1} не является квадратом числа {number_2}");
}
