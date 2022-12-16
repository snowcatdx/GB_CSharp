//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/* int[] getArray(int arrLength)
{
    int[] result = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        result[i] = new Random().Next(100, 999);
    }

    return result;
}

int countEven(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            result++;
        }
    }

    return result;
}

int[] myArr = getArray(9);

Console.WriteLine($"Это сгенерированный массив чисел: {String.Join(", ", myArr)}");
Console.WriteLine($"Это кол-во четных чисел в нем: {countEven(myArr)}"); */

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

 /* int[] getArray(int arrLength)
{
    int[] result = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        result[i] = new Random().Next(-99, 99);
    }

    return result;
}

int sumOdd(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
            result += array[i];
        }
    }

    return result;
}

int[] myArr = getArray(5);

Console.WriteLine($"Это сгенерированный массив чисел: {String.Join(", ", myArr)}");
Console.WriteLine($"Это сумма нечетных чисел в нем: {sumOdd(myArr)}"); */

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задача 37 со звездочкой, дополнительная: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21