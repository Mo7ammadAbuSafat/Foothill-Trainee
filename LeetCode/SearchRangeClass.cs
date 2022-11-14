using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    public class SearchRangeClass
    {
        public int[] SearchRange(int[] nums, int target)
        {
            List<int> list = new List<int>(nums);
            int[] result = new int[2];
            result[0] = list.IndexOf(target);
            result[1] = list.LastIndexOf(target);
            return result;
        }

        public int[] SearchRange2(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target == nums[mid])
                {
                    result[0] = result[1] = mid;
                    break;
                }
                else if (target < nums[mid])
                    right = mid - 1;
                else
                    left = mid + 1;

            }
            while (result[0] - 1 >= 0 && nums[result[0] - 1] == target)
                result[0] -= 1;

            while (result[1] + 1 < nums.Length && nums[result[1] + 1] == target)
                result[1] += 1;

            return result;
        }

        public int[] SearchRange3(int[] nums, int k)
        {
            int first = -1, last = -1;
            int l = 0, r = nums.Length - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] < k)
                    l = mid + 1;
                else if (nums[mid] > k)
                    r = mid - 1;
                else
                {
                    first = mid;
                    r = mid - 1;
                }
            }
            l = 0;
            r = nums.Length - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] < k)
                    l = mid + 1;
                else if (nums[mid] > k)
                    r = mid - 1;
                else
                {
                    last = mid;
                    l = mid + 1;
                }
            }
            return new int[] { first, last };
        }
    }
}
