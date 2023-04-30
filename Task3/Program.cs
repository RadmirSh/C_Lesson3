// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Please write number N: ");

int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Cube table:\n");

for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.Write($"{k} ");
}