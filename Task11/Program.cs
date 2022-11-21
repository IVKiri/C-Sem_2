// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число: {number}");

int dig1 = number/100;
int dig3 = number%10;

Console.Write(dig1);
Console.Write(dig3);