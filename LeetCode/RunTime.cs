
using static LeetCode.Sort;
namespace LeetCode
{
    class RunTime
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 58, 4, 1, 2, 2, 0 };
            Sort.SortColors(arr);
            Console.WriteLine(arr);
        }
    }
}
