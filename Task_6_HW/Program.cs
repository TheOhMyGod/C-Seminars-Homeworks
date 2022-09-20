Console.Write("Введите число: ");

int number = Convert.ToInt32 (Console.ReadLine());

int number_remainder = number % 2;

if (number_remainder == 0)
{
    Console.WriteLine ($"{number} - четное число!");
}

else
{
    Console.WriteLine ($"{number} - нечетное число!");
}
