﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;

if (number3 == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток от деления = {number3}");
}
