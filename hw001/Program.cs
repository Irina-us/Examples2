﻿Console.Clear();


// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите любое трехзначное число, программа выдаст вторую цифру этого числа");
int num = Convert.ToInt32( Console.ReadLine() );
int x1 = num / 10; // левая цифра двузначного числа = целочисленное деление на 10
int x2 = x1%10; // правая цифра двузначного числа = остаток от деления на 10
System.Console.WriteLine($"{num}->{x2}");