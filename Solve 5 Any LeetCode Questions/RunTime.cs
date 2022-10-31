using static Solve_5_Any_LeetCode_Questions.ValidParentheses;
using static Solve_5_Any_LeetCode_Questions.MedianOfTwoSortedArrays;
using static Solve_5_Any_LeetCode_Questions.StringToIntegerAtoi;
using static Solve_5_Any_LeetCode_Questions.ToeplitzMatrix;

namespace Solve_5_Any_LeetCode_Questions

{
    internal class RunTime
    {
        static public void Main()
        {
            //run for ValidParentheses
            Console.WriteLine(IsValid("{{{}}}"));

            //run for MedianOfTwoSortedArrays
            Console.WriteLine(findMedianSortedArrays(new int[] { 5, 7, 6 }, new int[] { 1, 2, 5, 8, 10 }));

            //run for StringToIntegerAtoi
            Console.WriteLine(MyAtoi("0010-45sdvdsvdsvdsves"));

            //run for ToeplitzMatrix
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 23,2};
            numbers[1] = new int[] { 2, 1, 23 };
            numbers[2] = new int[] { 1, 2, 1 };
            Console.WriteLine(IsToeplitzMatrix(numbers));

            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(1, 5);
            map.Add(5, 3);
        }
    }
}
