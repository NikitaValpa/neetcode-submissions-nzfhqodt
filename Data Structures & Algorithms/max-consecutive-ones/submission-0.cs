public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxSeq = 0;
        var currentSeq = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentSeq++;
            }
            
            if (nums[i] != 1 || i == nums.Length - 1)
            {
                if (maxSeq < currentSeq)
                {
                    maxSeq = currentSeq;
                }
                currentSeq = 0;
            }
        }

        return maxSeq;
    }
}