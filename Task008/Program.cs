// Удалить вторую цифру трёхзначного числа
//Console.Write("Введите трехзначное число: ");
//int number = int.Parse(Console.ReadLine());
//int a = (number / 100)*10;
//int c = number % 10;
//int N = a + c;
//Console.WriteLine(N);

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию");
int s = int.Parse(Console.ReadLine());
int m = 1;
while (s > 1) 
{
     m *= 10;
     s--;
}
int t = (x % m) + (x / (m * 10)) * m;
Console.WriteLine(t);