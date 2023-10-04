/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Prompt(string massage)
{
    Console.Write(massage);
    
    return Convert.ToInt32(Console.ReadLine());
}
int summa(int M, int N)
{ 
   if (M > N) return 0;
    return M+summa(M+1,N);
}
int M = Prompt("Значение 1 - ");
int N = Prompt("Значение 2 - ");
Console.WriteLine($"Сумма значений от {M} до {N} = {summa(M,N)}");