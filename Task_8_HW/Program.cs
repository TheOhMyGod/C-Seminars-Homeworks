Console.Write("Введите число: ");

int number = Convert.ToInt32 (Console.ReadLine());

int start_number = 1;

while (start_number < number + 1)
{
    int number_remainder = start_number % 2;
    if (number_remainder == 0) Console.WriteLine (start_number);
    start_number = start_number + 1;
}
