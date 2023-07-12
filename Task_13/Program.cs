// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number_input = int.Parse(Console.ReadLine());
int result_number = number_input;
if (result_number <0) 
result_number = result_number * (-1);
if (result_number /100 < 1) Console.WriteLine($"{result_number} -> Третьей цифры нет");
else
{
    while (result_number > 1000)
    {
        result_number = result_number / 10;
    }

    // Console.WriteLine($"{number_input} ->Третья цифра есть");
    if (result_number >= 100 && result_number <= 999) 
    {
        result_number = result_number % 10;
        Console.WriteLine($"{number_input} -> {result_number}");
    }
}