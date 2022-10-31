
namespace Solve_5_Any_LeetCode_Questions
{
    internal class ToeplitzMatrix
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for(int i = 0; i < matrix.Length; i++)
            {
                int r = i, c = 0;
                int no = matrix[i][0];
                while(r<matrix.Length&& c < matrix[0].Length)
                {
                    if(no!=matrix[r++][c++])
                        return false;
                }
            }
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int r = 0, c = i;
                int no = matrix[0][i];
                while (r < matrix.Length && c < matrix[0].Length)
                {
                    if (no != matrix[r++][c++])
                        return false;
                }
            }
            return true;
        }
    }
}
