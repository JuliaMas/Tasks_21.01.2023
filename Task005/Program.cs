//Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int a = number % 10;
Console.WriteLine(a);

