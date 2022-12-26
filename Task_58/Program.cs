/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrixA = 
{
    {2, 4},
    {3, 2}
};

int[,] matrixB = 
{
    {3, 4},
    {3, 3}
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

void ProizvMatrix (int[,] matrixA, int[,] mayrixB)
{
    int[,] matrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    int res = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  matrixA[i, j] * matrixB[i, j] + matrixA[i, j+1]*matrixB[i+1, j];
            Console.WriteLine(matrix[i,j]);
        }
    }

}
Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);
ProizvMatrix(matrixA, matrixB);