namespace Solve_5_Any_LeetCode_Questions
{
    internal class MedianOfTwoSortedArrays
    {
        public static double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[nums1.Length + nums2.Length];
            int i1 = 0, i2 = 0, i3 = 0;
            while (i1 < nums1.Length && i2 < nums2.Length)
            {
                if (nums1[i1] < nums2[i2])
                    nums3[i3++] = nums1[i1++];
                else nums3[i3++] = nums2[i2++];
            }
            while (i1 < nums1.Length)
                nums3[i3++] = nums1[i1++];
            while (i2 < nums2.Length)
                nums3[i3++] = nums2[i2++];
            if (nums3.Length % 2 == 1)
                return (nums3[nums3.Length / 2] * 1.0);
            else return ((nums3[nums3.Length / 2 - 1] + nums3[nums3.Length / 2]) / 2.0);
        }
    }
}
