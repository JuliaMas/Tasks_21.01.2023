// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());

if (daynumber < 0 || daynumber > 7) Console.WriteLine("В неделе 7 дней! Попробуйте ещё раз!");

if (daynumber == 1) Console.WriteLine("Понедельник");
if (daynumber == 2) Console.WriteLine("Вторник");
if (daynumber == 3) Console.WriteLine("Среда");
if (daynumber == 4) Console.WriteLine("Четверг");
if (daynumber == 5) Console.WriteLine("Пятница");
if (daynumber == 6) Console.WriteLine("Суббота");
if (daynumber == 7) Console.WriteLine("Воскресенье");