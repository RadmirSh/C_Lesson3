// задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputN(string message)

{
System.Console.Write($"{message}");
int value;

if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}

System.Console.WriteLine("You are entered not a number");
Environment.Exit(1);
return 0;

}
int x1 = InputN ("Write coordinate X of point A: ");
int y1 = InputN ("Write coordinate Y of point A: ");
int z1 = InputN ("Write coordinate Z of point A: ");
int x2 = InputN ("Write coordinate X of point B: ");
int y2 = InputN ("Write coordinate Y of point B: ");
int z2 = InputN ("Write coordinate Z of point B: ");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{

int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}

System.Console.Write($"The distance between points A and B is {dis(x1, y1, z1, x2, y2, z2):F2} ");