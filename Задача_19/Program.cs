// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
int a1 = N / 10000;
int a2 = N % 10;
int b1 = N / 1000;
int b2 = N % 100;

if (a1 == a2)
{
    Console.Write("Yes");
}

else
{
    if (b1 == b2)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
}