/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int Question(string text)
{
    Console.Write(text);
    int Ansver = Convert.ToInt32(Console.ReadLine());
    return Ansver;
}

bool IsADayWeek(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}
//Console.WriteLine(DayWeek());

int numberDay = Question("Введите номер дня недели -> "); 

if (IsADayWeek(numberDay))
{
    if (numberDay > 5) 
    { 
        Console.WriteLine("Выходной");
    }
    else
    {    
        Console.WriteLine("Работаем");
    }
}       


