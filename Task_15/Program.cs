//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите значение от 1 до 7");
int day_of_week = int.Parse(Console.ReadLine());
if (day_of_week <1 && day_of_week > 7) Console.WriteLine("Вы ввели неверное значение");
else
{
  if (day_of_week == 6 || day_of_week == 7) Console.WriteLine($"{day_of_week} -> да,выходной день");
    else
    {
        Console.WriteLine($"{day_of_week} -> нет, будний день");
    }
}
