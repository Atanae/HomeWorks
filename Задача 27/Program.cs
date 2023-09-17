/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

using System.Globalization;

int Prompt(string message)
{
    Console.Write(message);
    int rezult = Convert.ToInt32(Console.ReadLine());
    return rezult;
}

int summa(int numb)
{   
    int sum = 0;
    while (numb > 0)
    {
        sum += numb % 10;
        numb = numb / 10;  
    }
    return sum;
}
int number = Prompt("Введите число -> ");
Console.WriteLine($"Сумма всех цифр числа "+number+" будет "+ summa(number));

