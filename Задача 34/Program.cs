/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int Prompt(string message)
{
   Console.Write(message); 
   int answ = Convert.ToInt32(Console.ReadLine());
   return answ;
}
int [] GenArray (int len)
{
    int [] array = new int[len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = random.Next( 100, 1000 );
    }
    return array;
}
void PrintArray( int [] arr, int len)
{
    Console.Write("В массиве [ ");
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}
void PrintRez(int [] arr, int len)
{
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if ((arr[i] % 2) == 0 )
            count++;
    }    
    Console.Write($"] "+"четных чисел -> "+count );
}
int length = Prompt("Сколько нужно трехзначных чисел? -> ");
int [] array = GenArray (length); // формирую массив
PrintArray(array, length); //вывожу массив
PrintRez(array, length); //вывожу результат