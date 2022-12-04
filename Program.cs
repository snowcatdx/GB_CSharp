// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Пример: 
// 456 -> 5
// 782 -> 8 
// 918 -> 1

//-------------//

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstNumber = number / 10;
// int secondDigit = firstNumber % 10;

// Console.WriteLine("Вторая цифра: " + secondDigit);

//-------------//

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Пример: 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = 645;
// int thirdDigit;
// if (number > 99 && number < 1000)
// {
//     while (number > 999)
//     {
//         number = number / 1000;
//     }
//     thirdDigit = number % 10;
//     Console.WriteLine(number);
//     Console.WriteLine(thirdDigit);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

//-------------//

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Пример: 
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("не выходной или неправильная цифра");
}



