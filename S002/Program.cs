// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.Clear();

int num1 = new Random().Next(1,100);
int num2 = new Random().Next(1,10);
System.Console.WriteLine($"Были сгенерированы 2 случайных числа {num1} и {num2}");

int x1 = num1 % num2;
// System.Console.WriteLine(x1);

if (x1 == 0)
    System.Console.WriteLine("Кратно");
else
    System.Console.WriteLine($"Не кратно, остаток = {x1}");
