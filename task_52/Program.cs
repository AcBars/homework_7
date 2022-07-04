/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using static System.Console;
using MyLib;

Clear();

WriteLine("Введите размер массива через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray =Ex.GetArray(m, n);
Ex.PrintArray(mainArray);
double [] arithmeticMean=ArithmeticMeanСolumns(mainArray);
PrintArray(arithmeticMean);



double [] ArithmeticMeanСolumns(int [,] array)
{
    double [] mean_colums=new double [array.GetLength(1)];
    for (int i=0; i<array.GetLength(1);i++)
    {
        double sum=0.0;
        for(int j=0; j<array.GetLength(0);j++)
        {
            sum+=array[j,i];
        }
        mean_colums[i]=sum/array.GetLength(0);
        
    }
    return mean_colums;
}

void PrintArray (double [] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            WriteLine($"Среднее арифметическое элементов столбца {i} равно {result[i]}");
          
        }
    }