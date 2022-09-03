// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число: ");
double first_number = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double second_number = double.Parse(Console.ReadLine());

Console.WriteLine("Возведение первого числа в степень второго: ");
Console.WriteLine(Math.Pow(first_number, second_number));