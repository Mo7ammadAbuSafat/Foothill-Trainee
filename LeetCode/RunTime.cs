using static LeetCode.Sort;
using static LeetCode.LargestSum;
using static LeetCode.RotateRight;
namespace LeetCode
{
    class RunTime
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 58, 4, 1, 2, 2, 0 };
            SortColors(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+", ");
            Console.WriteLine();
            int[] arr2 = new int[] { 0, 0 };
            Console.WriteLine(LargestNumber(arr2));
        }
    }
}
