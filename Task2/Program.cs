// Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
if (n < 100)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    while (n1 >= 1000)
    {
        n1 = n1 / 10;
    }    
    Console.WriteLine($"Третья цифра числа: {n1 % 10 % 10}");
}