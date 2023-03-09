// Напишите программу, которая заполнит спирально массив 4 на 4. 

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateSpiralMatrix(int line, int column)
{
    int i = 0, j = 0;
    int iBeg = 0, jBeg = 0, iFin = 0, jFin = 0;
    int start = 1;
    int[,] spiral = new int[line, column];
    while (start <= line * column)
    {
        spiral[i, j] = start;
        if (i == iBeg && j < column - jFin - 1) j++;
        else if (j == column - jFin - 1 && i < line - iFin - 1) i++;
        else if (i == line - iFin - 1 && j > jBeg) j--;
        else i--;

        if ((i == iBeg + 1) && (j == jBeg) && (jBeg != column - jFin - 1))
        {
            iBeg++;
            iFin++;
            jBeg++;
            jFin++;
        }
        start++;
    }
    return spiral;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int myLine = ReadInt("Введите количество строк спирали: ");
int myColumn = ReadInt("Введите количество столбцов спирали: ");
int[,] mySpiral = GenerateSpiralMatrix(myLine, myColumn);
PrintMatrix(mySpiral);