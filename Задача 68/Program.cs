/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Prompt(string massage)
{
    Console.Write(massage);
    
    return Convert.ToInt32(Console.ReadLine());
}
int akker(int m, int n)
{
    if (m==0) return n+1;
    else if(n==0) return akker(m-1,1);
         else 
            return akker(m-1,akker(m,n-1));
}

int m = Prompt("Задайте значение m ");
int n = Prompt("Задайте значение n ");
Console.Write($"Функция Аккермана от {m} и {n} = {akker(m,n)}");