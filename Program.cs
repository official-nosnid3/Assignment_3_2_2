using System.Xml.Linq;

namespace Assignment_3_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.2.2
             * Write a program in C# Sharp for addition of two Matrices of same size.
             * Test Data :
             * Input the size of the square matrix (less than 5): 2
             * Input elements in the first matrix :
             * element - [0],[0] : 1
             * element - [0],[1] : 2
             * element - [1],[0] : 3
             * element - [1],[1] : 4
             * Input elements in the second matrix :
             * element - [0],[0] : 5
             * element - [0],[1] : 6
             * element - [1],[0] : 7
             * element - [1],[1] : 8
             * Expected Output:
             * The First matrix is:
             * 1 2
             * 3 4
             * The Second matrix is :
             * 5 6
             * 7 8
             * The Addition of two matrix is :
             * 6 8
             * 10 12
             * */
            int maxSize = 3;
            int[,] matrixOne = new int[maxSize, maxSize];
            int[,] matrixTwo = new int[maxSize, maxSize];
            int[,] sumMatrix = new int[maxSize, maxSize];

            do
            {
                Console.Clear();

                Console.WriteLine("Adding two 2-D matrices of the same size");
                Console.WriteLine($"Input the size of the square matrix (less than {maxSize + 1}): ");

                try
                {
                    int matrixSize = Convert.ToInt32(Console.ReadLine());
                    if (matrixSize > maxSize || matrixSize < 1) break;

                    Console.WriteLine($"Input the {matrixSize * matrixSize} elements in the first matrix: ");
                    matrixOne = GetMatrixElements(matrixOne, matrixSize);

                    Console.WriteLine($"Input the {matrixSize * matrixSize} elements in the second matrix: ");
                    matrixTwo = GetMatrixElements(matrixTwo, matrixSize);

                    sumMatrix = AddMatrices(matrixOne, matrixTwo, sumMatrix, matrixSize);

                    Console.WriteLine("The first matrix is: ");
                    PrintMatrix(matrixOne, matrixSize);

                    Console.WriteLine("The second matrix is: ");
                    PrintMatrix(matrixTwo, matrixSize);

                    Console.WriteLine("The Addition of the two matrix is: ");
                    PrintMatrix(sumMatrix, matrixSize);

                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.ToString());
                    Console.ReadLine();
                }
            }
            while (true);

        }

        static int[,] GetMatrixElements(int[,] Matrix, int MatrixSize_)
        {
            for (int i = 0; i < MatrixSize_; i++)
                for (int j = 0; j < MatrixSize_; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            return Matrix;
        }

        static int[,] AddMatrices(int[,] MatrixOne_, int[,] MatrixTwo_, int[,] SumMatrix_, int MatrixSize_)
        {
            for (int i = 0; i < MatrixSize_; i++)
                for (int j = 0; j < MatrixSize_; j++)
                {
                    SumMatrix_[i, j] = MatrixOne_[i, j] + MatrixTwo_[i, j];
                }
            
            return SumMatrix_;
        }

        static void PrintMatrix(int[,] Matrix, int MatrixSize_)
        {
            for (int i = 0; i < MatrixSize_; i++ )
            {
                for (int j = 0; j < MatrixSize_; j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
