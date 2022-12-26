/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] matrix = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SortingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPossRow = i;
            int minPossColl = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i,k]> matrix[minPossRow, minPossColl])
                {
                    minPossColl = k;
                } 
            }
            int temporary = matrix[i,j];
            matrix[i, j] = matrix[minPossRow, minPossColl];
            matrix[minPossRow, minPossColl] = temporary;
            
        }
    }
}
PrintMatrix(matrix);
SortingMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный список в порядке убывания");
Console.WriteLine();
PrintMatrix(matrix);