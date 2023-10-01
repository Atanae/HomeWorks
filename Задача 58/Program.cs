/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] GetMult (int[,] arr1, int[,] arr2)
{
    int[,] rezalt = new int[arr1.GetLength(0),arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                rezalt[i,j] += arr1[i,k]*arr2[k,j];
            }
        }

    }
return rezalt;
}

Console.WriteLine("Формируем матрицы М1 и М2");
int rows1 = Prompt("М1: сколько строк - ");
int colls1 = Prompt("М1: сколько столбцов - ");
int rows2 = Prompt("М2: сколько строк - ");
int colls2 = Prompt("М2: сколько столбцов - ");

if (colls1 == rows2)
{
    int minValue = Prompt("Случайные числа от - ");
    int maxValue = Prompt("Случайные числа до - ");
    int[,] array1 = GetArray(rows1,colls1,minValue,maxValue);
    int[,] array2 = GetArray(rows2,colls2,minValue,maxValue);
    PrintArray("Матрица 1 ", array1);
    PrintArray("Матрица 2 ", array2);
    int[,] mult = GetMult(array1,array2);
    PrintArray("Произведение матриц", mult);
}
else Console.WriteLine("Такие матрицы перемножить не получится!!!");
