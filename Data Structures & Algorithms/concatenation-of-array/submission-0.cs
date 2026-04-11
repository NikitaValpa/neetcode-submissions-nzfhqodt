public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new int[nums.Length * 2];
        for (var i=0; i < ans.Length; i++)
        {
            ans[i] = nums[i % nums.Length];
        }

        return ans;
    }
}