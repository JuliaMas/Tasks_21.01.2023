// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int a = N / 10;
int b = N % 10;
if(a > b)
{
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine(b);
}
