﻿// Программа задает матрицу м на н каждый элемент находится по формуле Амн = м+н

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = i+j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}

int M = ReadInt("Введите количество строк матрицы: ");
int N = ReadInt("Введите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(M,N);
PrintMatrix(myMatrix);