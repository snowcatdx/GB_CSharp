﻿// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* int MyPow(int a, int b)
{
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result *= a;
    }

    return result;
}

Console.WriteLine(MyPow(3, 7));
//Проверка
Console.WriteLine(Math.Pow(3, 7)); */

// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/* int MySum(int number)
{
    int digit = number % 10;
    int result = digit;

    while (number != 0)
    {      
        number /= 10; 
        digit = number % 10;  
        result += digit;
    }

    return result;
}
Console.WriteLine(MySum(161616)); */

// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

