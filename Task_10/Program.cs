//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число");
int number_input = int.Parse(Console.ReadLine());
int number_result = (number_input % 100) /10;
Console.WriteLine($"{number_input} -> {number_result}");

