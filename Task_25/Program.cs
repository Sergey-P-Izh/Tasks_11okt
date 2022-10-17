// See https://aka.ms/new-console-template for more information
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int stepen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("number^stepen = " + Math.Pow(number, stepen));
Console.ReadLine();

//int x = 5;
//int stepen = 4;
//Console.WriteLine("5^4 = " + Math.Pow(x, stepen));