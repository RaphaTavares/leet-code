public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        HashSet<int> window = new();

        int start = 0;

        for(int i = 0; i < nums.Length; i++){
            if(i - start > k){
                window.Remove(nums[start]);
                start++;
            }

            if(window.Contains(nums[i]))
                return true;

            window.Add(nums[i]);
        }

        return false;
    }
}