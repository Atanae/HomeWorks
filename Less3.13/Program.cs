/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
123456789 -> 3*/

string ThirdDigit()
{
    Console.Write("Введите любое число -> "); 
    string textDigit = (Console.ReadLine());
   
    if (textDigit.Length < 3)
        return("Третьей цифры нет");
    else 
        return("Третья цифра "+textDigit[2]);    
}
Console.WriteLine(ThirdDigit());