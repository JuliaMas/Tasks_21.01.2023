// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("А является квадратом В");
}
else
{
    Console.WriteLine("А не является квадратом В");
}