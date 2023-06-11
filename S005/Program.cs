// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет

Console.Clear();

System.Console.WriteLine("Проверим является ли одно число квадратом другого");
System.Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32( Console.ReadLine() );
System.Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32( Console.ReadLine() );

int result1 = num1 * num1;
int result2 = num2 * num2;
if (result1 == num2 || result2 == num1) //  знак  ||  = или
    System.Console.WriteLine("Одно из чисел является квадратом другого");
else
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");