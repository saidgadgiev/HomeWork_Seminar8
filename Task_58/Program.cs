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
 

// int[,] matrixA = 
// {
//     {2, 4},
//     {3, 2}
// };

// int[,] matrixB = 
// {
//     {3, 4},
//     {3, 3}
// };

int[,] matrixA = 
{
    {2, 6, 0},
    {1, 4, 3}
};

int[,] matrixB = 
{
    {4, -1},
    {7,  5},
    {8, -3}
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            int res = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                res =  res + (matrixA[i, k] * matrixB[k, j]);
            }
            Console.Write(res + " ");
            
        }
        Console.WriteLine();
    }

}
Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B:");

PrintMatrix(matrixB);
Console.WriteLine("Произведение двух матриц: ->");
ProizvMatrix(matrixA, matrixB);