// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да

Console.Clear();

System.Console.WriteLine("Проверим делится ли введеное число на 7 и 23 одновременно");
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32( Console.ReadLine() );
int a = 7;
int b = 23;

if (num % a ==0 && num % b ==0)
    System.Console.WriteLine($"делится");
else 
    System.Console.WriteLine($"не делится");
