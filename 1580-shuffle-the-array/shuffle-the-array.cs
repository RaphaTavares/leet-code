public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        var start = 0;
        var mid = n;
        List<int> result = new();

        while(start < n)
        {
            result.Add(nums[start]);
            result.Add(nums[mid]);

            start++;
            mid++;
        }

        return result.ToArray();
    }
}