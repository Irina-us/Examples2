// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98

Console.Clear();

int num = new Random().Next(100,1000);
System.Console.WriteLine($"Было сгенерировано случайное число {num}");

int x1 = num / 100;
int x2 = num%10; 
System.Console.Write($"{x1}{x2}");
// for (int i=1; i<=100; i++)
// System.Console.Write($"{i} ");