/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Случайные числа из диапазона.");

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
    Console.WriteLine("Созданный массив:");
    int i=0;
    while (i<len-1)
    {
        Console.Write(arr[i]+ ", ");
        i++;
    }
    Console.Write(arr[i]);
    return;
}
int length = Prompt("Сколько нужно чисел? -> ");
int min = Prompt("Числа от -> ");
int max = Prompt("Числа до -> ");
int [] array = GenArray (length, min, max); // формирую массив
PrintArray(array, length); //вывожу массив
