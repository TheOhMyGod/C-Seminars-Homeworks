int number = 2;
int d10 = 1;
int result = 0;
while (number != 0)
{
    result = result + number % 2 * d10;
    number = number / 2;
    d10 = d10 * 10;
}
Console.WriteLine(result);