int x = new Random().Next(10, 100);
int x1 = x / 10;
int x2 = x % 10;

Console.WriteLine($"Сгенерированное случайное число - {x}");

if (x1>x2) Console.WriteLine($"Первая цифра - {x1} больше");
else if (x2>x1)Console.WriteLine($"Вторая цифра - {x2} больше");
else Console.WriteLine("Это паллиндром!");
