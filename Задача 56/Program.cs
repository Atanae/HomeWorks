/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int Prompt(string massage)
{
    Console.Write(massage);
    
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)    
        {
        array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(string mass, int[,] array)
{
 Console.WriteLine(mass);   
 for (int i=0; i< array.GetLength(0); i++)
    {
      for (int j=0; j<array.GetLength(1); j++)
      {
        Console.Write($"{array[i,j]}"+"\t");
      }
      Console.WriteLine();
    }
    return;
}

int MinRowSum(int[,] array)
{
 int RowSum, Row=0, TempSum = 0;
 for (int i = 0; i < array.GetLength(0); i++) //строка
 {
    RowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++) // столбцы
    {   
        RowSum += array[i, j];
    }
    if (i == 0) 
    {
        TempSum = RowSum;
        Row = i;
        Console.WriteLine("строка "+i+ " сумма  "+RowSum);
    }
    else 
    {
        if (TempSum > RowSum)
        {   
            TempSum = RowSum;
            Row = i;
        }          
    Console.WriteLine("строка "+i+ " сумма  "+RowSum+" минимальная "+TempSum);   
    }     
}
return Row;
}   
   


int rows = Prompt("Сколько строк - ");
int colls = Prompt("Сколько столбцов - ");
int minValue = Prompt("Случайные числа от - ");
int maxValue = Prompt("Случайные числа до - ");
int[,] array = GetArray(rows,colls,minValue,maxValue);
PrintArray("Задан массив", array);
int numRow = MinRowSum(array);
Console.WriteLine("Строка с наименьшей суммой элементов " +numRow);