/* Lesson 3.4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Какое из трех чисел максимальное?");
Console.WriteLine("Первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число: ");
int numb3 = Convert.ToInt32(Console.ReadLine());
int numbmax; 
numbmax = numb2 > numb1 ? numb2 : numb1;
numbmax = numbmax > numb3 ? numbmax : numb3;
Console.WriteLine("Максимальное число "+numbmax);

