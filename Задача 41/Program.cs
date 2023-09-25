/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

using System.Xml.XPath;

int HowManyNumbers(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine());
}

int HowPositiv (int how)
{
    int rezalt = 0;
    for (int i = 1; i <= how; i++)
    {
        Console.Write("Введите число "+i+" -> ");
        if (Convert.ToInt32(Console.ReadLine()) > 0)
            rezalt++;
    }    
    return rezalt;
}
int count = HowManyNumbers("Сколько будет чисел? ");

Console.WriteLine($"Введено цифр больше 0 -> "+HowPositiv(count));

