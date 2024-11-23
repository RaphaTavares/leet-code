public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        for(int i = 0; i < nums.Length; i++){
            int counter = 1;

            while(counter <= k)
            {
                if(i+counter < nums.Length && nums[i] == nums[i+counter])
                    return true;

                counter++;
            }
        }

        return false;
    }
}