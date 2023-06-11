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

//альтернативный вариант
// for (int i=1; i<=100; i++)
// System.Console.Write($"{i} ");

// В числе любой разрядности, удалить 2ую цифру

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32( Console.ReadLine() );

// int count = 0;
// int num2 = 0;

// while (num > 1)
// {
//     num2 = num/10;
//     count++;
// }
// System.Console.WriteLine(count);

// int x1 = num /(count-1);
// System.Console.WriteLine(x1);
// было бы неплохо решить эту сраную задачку