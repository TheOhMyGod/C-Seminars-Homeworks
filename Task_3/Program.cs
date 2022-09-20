Console.Write("Введите номер дня недели: ");
int number = int.Parse (Console.ReadLine());

if (number == 1) Console.WriteLine("Первый день недели - Понедельник.");
if (number == 2) Console.WriteLine("Второй день недели - Вторник.");
if (number == 3) Console.WriteLine("Третий день недели - Среда.");
if (number == 4) Console.WriteLine("Четвертый день недели - Четверг.");
if (number == 5) Console.WriteLine("Пятый день недели - Пятница.");
if (number == 6) Console.WriteLine("Шестой день недели - Суббота.");
if (number == 7) Console.WriteLine("Седьмой день недели - Воскресенье.");
if (number > 7) Console.WriteLine("В неделе семь дней!");
