// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a > 99)
{
    while (a > 999)
    {
        a /= 10;  
    }
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}