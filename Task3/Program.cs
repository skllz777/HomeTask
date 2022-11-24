// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 0 || day >= 8)
    Console.WriteLine("Вы ввели несуществующий день недели");
else if (day > 0 && day <= 5)
Console.WriteLine("Это будний день");
else if (day == 6 || day == 7)
Console.WriteLine("Это выходной день");