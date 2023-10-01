/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int Prompt(string massage)
{
    Console.Write(massage);
    
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int el = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)    
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = el++;
            }
                
        }
    }
    return array;
}

void PrintArray(string mass, int[,,] array)
{
 Console.WriteLine(mass);   
 for (int i=0; i< array.GetLength(0); i++)
    {
      for (int j=0; j<array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i,j,k]}"+"("+i+","+j+","+k+")");
            }
      }
//      Console.WriteLine();
    }
    return;
}

Console.WriteLine("Формируем трехмерный массив");
int size1 = Prompt("Размер 1 - ");
int size2 = Prompt("Размер 2 - ");
int size3 = Prompt("Размер 3 - ");
int[,,] array = GetArray(size1, size2, size3);
PrintArray("Элементы массива с индексами", array);