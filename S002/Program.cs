// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4
// ● 16, 4 -> кратно

Console.Clear();

// int num1 = new Random().Next(1,100);
// int num2 = new Random().Next(1,10);
// System.Console.WriteLine($"Были сгенерированы 2 случайных числа {num1} и {num2}");

System.Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32( Console.ReadLine() );
System.Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32( Console.ReadLine() );

int x1 = num1 % num2;

if (num1 < num2)
    System.Console.WriteLine($"{num1} не делится на {num2}");
else 
    if (x1 == 0)
    System.Console.WriteLine($"{num1} кратно {num2}");
else
    System.Console.WriteLine($"{num1} не кратно {num2}, остаток = {x1}");
