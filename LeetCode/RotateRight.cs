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

        public static void Rotate2(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] result = new int[nums.Length];
            Array.Copy(nums, 0, result, 0, nums.Length);
            for (int i = 0; i < nums.Length; i++)
                nums[i] = result[(i - k + nums.Length) % (result.Length)];
        }
    }
}
