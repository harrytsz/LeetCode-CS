//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.3 MB
// Link: https://leetcode.com/submissions/detail/352344600/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    using System.Collections.Generic;

    public class _001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2]{-1, -1};
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                int tmp = target - nums[i];
                if (dic.ContainsKey(tmp)) {
                    res[0] = dic[tmp];
                    res[1] = i;
                }
                dic[nums[i]] = i;
            }
            return res;
        }
    }
}
