// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
System.Console.WriteLine("Введите любое число, программа выдаст третью цифру этого числа, или сообщит, что третьей цифры нет");
int num = Convert.ToInt32( Console.ReadLine() );

while (num > 999)
{ 
    num /=10;
    System.Console.WriteLine($"Третья цифра {num%10}");
}
    

if (num < 100)
{
    System.Console.WriteLine($"Третьей цифры нет");
}

// int num = Convert.ToInt32( Console.ReadLine() );)
    
//     if (num<100)
//     System.Console.WriteLine($"Третьей цифры нет");

//     else
//     if (num > 999)
//     System.Console.WriteLine($"Третья цифра {num%10}");

    

 
