/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

int[,] SortMaxMin(int[,] array)
{
 int temp;
 for (int i = 0; i < array.GetLength(0); i++) //строка
    {
    for (int k=0; k < array.GetLength(1); k++) // проходы
      {  
        for (int j = 0; j < array.GetLength(1)-1-k; j++) // столбцы
           {
                if (array[i,j] < array[i,j+1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            } 
      }   
    }    
    return array;
}

int rows = Prompt("Сколько строк - ");
int colls = Prompt("Сколько столбцов - ");
int minValue = Prompt("Случайные числа от - ");
int maxValue = Prompt("Случайные числа до - ");
int[,] array = GetArray(rows,colls,minValue,maxValue);
PrintArray("Массив изначальный", array);
int[,] arraySort = SortMaxMin(array);
PrintArray("Массив отсортированный", arraySort);