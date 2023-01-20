// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число A =  "); // Заданное число
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B = ");  
int B = int.Parse(Console.ReadLine());
int n = A % B;
if(A % B == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine("Число не кратно, остаток равен " + n);
}