public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var newLength = nums.Length;
        for(var i = 0; i < newLength; i++)
        {
            if (nums[i] == val){
                for(var j = i; j < newLength; j++)
                {
                    if (j == newLength - 1)
                    {
                        newLength--;
                        i = -1;
                        break;
                    }
                    nums[j] = nums[j+1];
                }
            }
        }

        return newLength;
    }
}