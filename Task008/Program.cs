// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a = (number / 100)*10;
int c = number % 10;
int N = a + c;
Console.WriteLine(N);
