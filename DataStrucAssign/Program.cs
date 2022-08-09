using System;
using System.Collections.Generic;

namespace DataStrucAssign
{
    public class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MatrixMultiplication");
            Console.WriteLine();

            // Multidimensional Arrays
            int[,,] matrixA = new int[3, 3, 3]
            {
                { {1, 2, 3},{4,5,6}, {3,2,3} },
               { {1, 2, 3},{4,5,6}, {3,2,3}},
               { {1, 2, 3},{4,5,6}, {3,2,3} }
            };



            int[,,] matrixB = new int[3, 3, 3]
            {
                { {5,6,8 }, {7,8,9}, {9,10,11} },
                { {5,6,8 }, {7,8,9}, {9,10,11} },
                { {5,6,8 }, {7,8,9}, {9,10,11} }
            };

            int[,,] result = new int[3, 3, 3];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixA.GetLength(2); k++)
                    {
                        result[i, j, k] += matrixA[i, j, k] * matrixB[i, j, k];
                    }
                }
            }

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }


        }

    }
}
