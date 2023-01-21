// Найти третью цифру числа или сообщить, что её нет
/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(number);
if(numberText.Length > 2)
{
    Console.WriteLine("Третья цифра = " + numberText[2]);
}
else
{
    Console.WriteLine("Третья цифра отсутствует");
}
*/
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N < 0) N = -N;
if(N > 99)
{
while(N > 999) N /=10;
int number = N % 10;

Console.WriteLine("Третья цифра = " + number);
}
else
{
   Console.WriteLine("Третья цифра отсутствует"); 
}