/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


using static System.Console;
using MyLib;

Clear();

WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray =Ex.GetArray(m, n);
Ex.PrintArray(mainArray);

WriteLine("Введите номер позиции элемента в матрице, через запятую");
string[] position = ReadLine().Split(',', '.', StringSplitOptions.RemoveEmptyEntries);
int position0=int.Parse(position[0]);
int position1=int.Parse(position[1]);
if (position0>m-1 || position1>n-1) WriteLine("Элемента на этой позиции не существует");
else WriteLine(mainArray[position0,position1]);