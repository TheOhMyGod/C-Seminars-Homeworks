Console.Write("Введите число: ");
int number = int.Parse (Console.ReadLine());

int start_number = Math.Abs(number) * -1;

while (start_number < number + 1)
{
    Console.WriteLine (start_number);
    start_number = start_number + 1;
}
