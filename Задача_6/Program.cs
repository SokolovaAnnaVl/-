// Напишите программу, которая на вход принимает 
// число и выдает, является ли число четным (делится ли оно на 
// два без остатка)

int N;
Console.WriteLine("Введите число N ");
N = Convert.ToInt32(Console.ReadLine());

if ((N % 2) == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
