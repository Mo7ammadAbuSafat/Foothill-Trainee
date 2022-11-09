namespace LeetCode
{
    public class SearchRangeClass
    {
        public int[] SearchRange(int[] nums, int target)
        {
            List<int> list = new List<int>(nums);
            int[]result=new int[2];
            result[0]=list.IndexOf(target);
            result[1]=list.LastIndexOf(target);
            return result;
        }
    }
}
