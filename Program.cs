// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/* Console.WriteLine("Введите числа в строку через пробел:");
string userInput = Console.ReadLine();
string[] array = userInput.Split(' ');
int result = 0;

foreach (var item in array)
{
    int number = Convert.ToInt32(item);

    if (number > 0)
    {
        result++;
    }
}
Console.WriteLine($"Пользователь ввел {result} положительных чисел отличных от нуля"); */

// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/* Console.Write("Введите b1");
Console.Write("Введите k1");
Console.Write("Введите b2");
Console.Write("Введите k2");

int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine()); */



// Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());
int rest;
string result = string.Empty;
while (number > 0)
{    
    rest = number % 2;
    number = number / 2;
    result = rest.ToString() + result;
}

Console.Write(result);