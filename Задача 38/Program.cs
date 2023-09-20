/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double FindMax ( double [] mass, double max)
{
    for (int i=1; i < mass.Length; i++)
    {
        if (max <= mass[i])
        {   
            max = mass[i];
        }    
    }
    return max;
}
double FindMin ( double [] mass, double min)
{
    for (int i=1; i < mass.Length; i++)
    {
        if (min >= mass[i])
        {   
            min = mass[i];
        }    
    }
    return min;
}
double [] massiv = {3.22, 4.2, 1.15, 77.15, 65.2};
double VolueMin = FindMin( massiv, massiv[0] ); 
double VolueMax = FindMax( massiv, massiv[0] );

Console.WriteLine((VolueMax - VolueMin));