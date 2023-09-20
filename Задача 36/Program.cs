/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

using System.Reflection.Metadata.Ecma335;

int Prompt(string message)
{
    Console.Write(message);
    int answ = Convert.ToInt32(Console.ReadLine());
    return answ;
}
int [] GenArray (int len, int dmin, int dmax )
{
    int [] array = new int[len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = random.Next( dmin, dmax+1 );
    }
    return array;
}
void PrintArray(int[] arr, int len)
{
    Console.Write("Созданный массив: ");
    int i=0;
    while (i<len-1)
    {
        Console.Write(arr[i]+ ", ");
        i++;
    }
    Console.WriteLine(arr[i]);
    return;
}
void PrintRez(int[] arr, int len, string mess)
{
    int sum = 0;
    for (int i = 0; i < len; i+=2)
    {
        sum +=arr[i];
    }
    Console.Write(mess+sum);
}
Console.WriteLine("Давайте создадим массив");
int length = Prompt("Сколько будет чисел? -> ");
int min = Prompt("от -> ");
int max = Prompt("и до -> ");
int [] array = GenArray (length, min, max); // формирую массив
PrintArray(array, length); //вывожу массив
PrintRez(array, length, "Сумма элементов, стоящих на нечетных позициях = ");
