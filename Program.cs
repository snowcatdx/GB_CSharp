/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number / 10000;
int digit2 = (number / 1000) % 10;
int digit4 = (number / 10) % 10;
int digit5 = number % 10;

if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("Палиндром");
} else
{
    Console.WriteLine("Не палиндром");
}



/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.WriteLine("Введите координату A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Y: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"Расстояниe между точками: {Math.Round(d, 3)}"); */

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double cube = Math.Pow(i, 3);
    Console.Write($"{cube} ");
} */


