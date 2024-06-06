public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        var uniqueValues = new HashSet<int>();

        for(var i = 0; i < nums.Length; i++)
        {
            if(uniqueValues.Contains(nums[i]))
                return true;

            uniqueValues.Add(nums[i]);
        }
        return false;
    }
}
// Best runtime complexity: O(1)
// Worst runtime complexity: O(n)