// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int count,r,sum=0,t;

Console.Write("Please write five-digit number: ");
count = Convert.ToInt32(Console.ReadLine());

if(count>9999 && count<100000)
{
for(t=count;count!=0;count=count/10)
{
r=count % 10;
sum=sum*10+r;
}
if(t==sum)
Console.Write($"{t} is a palindrome");
else
Console.Write($"{t} is not a palindrome");
} else
Console.Write("Please write five-digit number");