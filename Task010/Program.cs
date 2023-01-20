// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число: ");
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
