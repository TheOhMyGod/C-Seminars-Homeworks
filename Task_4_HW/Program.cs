Console.Write ("Введите число 1: ");
int number_A = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число 2: ");
int number_B = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите число 3: ");
int number_C = Convert.ToInt32 (Console.ReadLine());

int max = number_A;

if (number_A > number_B) max = number_A;
if (number_B > number_C) max = number_B;
if (number_C > number_A) max = number_C;

Console.WriteLine ($"Наибольшее число - {max}");
