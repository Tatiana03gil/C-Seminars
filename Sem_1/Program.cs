﻿//int a = 25;
//double b = 2.5;
//string c = "Hello";
//bool d = false;

//int number = 5;

//Console.WriteLine("My namber is " + number + " (five)"); //конкотинация
//Console.WriteLine($"My namber is {number} (five)"); //форматирование

//Console.Write ("Введите данные: ");
//int num = Convert.ToInt32(Console.ReadLine ()); 
// конвертирует вводимое число (строку) в число
//Console.WriteLine ("Наше число это " + num);

//Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.

int num1, num2;
Console.WriteLine ("Введите первое число: ");
num1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите первое число: ");
num2 = Convert.ToInt32 (Console.ReadLine ());
int kvad = num2*num2;

if (num1 == kvad)
 {
    Console.WriteLine ("true");
 }
    else 
 {
    Console.WriteLine ("false");
 }
