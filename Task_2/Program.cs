Console.Write ("Введите число 1: ");
int number_A = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число 2: ");
int number_B = Convert.ToInt32 (Console.ReadLine());

int max = 0;

if (number_A > number_B)
{
    Console.WriteLine ($"Из двух введеных чисел, наибольшее - {number_A}");
}

else
{
    Console.WriteLine ($"Из двух введеных чисел, наибольшее - {number_B}");
}
