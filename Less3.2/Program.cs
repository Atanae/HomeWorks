/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Какое число больше, какое меньше?");
double num1, num2;
Console.WriteLine("Введите первое число: ");
num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(num1);
Console.WriteLine("Введите второе число: ");
num2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(num2);
if (num1 > num2) 
{
    Console.WriteLine(num1 + " больше " + num2);
    Console.WriteLine(num2 + " меньше " + num1);
}
else
{
    Console.WriteLine(num1 + " больше " + num2); 
    Console.WriteLine(num2 + " меньше " + num1); 
}
 