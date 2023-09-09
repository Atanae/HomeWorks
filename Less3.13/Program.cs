/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
123456789 -> 3*/

string ThirdDigit()
{
    Console.Write("Введите любое число -> "); 
    int digit = Convert.ToInt32(Console.ReadLine());
   
    if (digit < 100)
        return("Третьей цифры нет");
    else 
        while(digit > 999)
            digit /= 10;
        return("Третья цифра "+Convert.ToString(digit % 10));    
}
Console.WriteLine(ThirdDigit());