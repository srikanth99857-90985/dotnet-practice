using System;
using System.Collections.Generic;


namespace oops2
{
    public class SumOfDiagonal
    {
        int[][] matrix = new int[][]
        {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
        };

        public float GetDiagonalSum()
        {
            float sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][i]+ matrix[i][matrix.Length-i-1];
            }
            if(matrix.Length % 2 != 0)
            {
                sum -= matrix[matrix.Length / 2][matrix.Length / 2];
            }
            return sum;
        }
    }
}

