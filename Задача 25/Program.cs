/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Prompt(string message)
{
    Console.Write(message);
    int rezult = Convert.ToInt32(Console.ReadLine());
    return rezult;
}

bool validexpon (int stepen)
{
    if (stepen < 0)
        return false;
    return true;    
}
int arg = Prompt("Введите число -> ");
int expon = Prompt("Введите степень -> ");
int rezult(int a, int b)
{
    int rez = 1;
for ( int i = 0; i < b; i++)
   rez = rez * a;
   return (rez);
}

if (validexpon(expon))
{
    Console.WriteLine($"Число "+arg+" в степени "+expon+" равно "+ rezult(arg,expon));
}
else
{
    Console.WriteLine("Степень не должна быть отрицательной");
}