namespace LeetCode
{
    public class RotateRight
    {
        public static void Rotate(int[] nums, int k)
        {
            LinkedList<int> list = new(nums);
            while (--k >= 0)
            {
                int x= list.Last.Value;
                list.RemoveLast();
                list.AddFirst(x);
            }
            int index = 0;
            foreach (int x in list)
            {
                nums[index++] = x;
            }
        }
    }
}
