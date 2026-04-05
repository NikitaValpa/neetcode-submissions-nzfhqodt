public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxItem = 0;
        if (arr.Length > 1)
        {
            maxItem = arr[1];
        }else
        {
            maxItem = arr[0];
        }

        for(var i=0; i < arr.Length; i++)
        {
            for (var j = i+1; j < arr.Length; j++)
            {
                if (arr[j] > maxItem)
                {
                    maxItem = arr[j];
                }
            }

            if (i == arr.Length-1)
            {
                arr[i] = -1;
            }else
            {
                arr[i] = maxItem;
                maxItem = 0;
            }
        }

        return arr;
    }
}