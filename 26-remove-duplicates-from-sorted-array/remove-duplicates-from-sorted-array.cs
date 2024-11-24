public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var index = 1;
        var number = nums[0];

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] != number){
                nums[index] = nums[i];
                number = nums[i];
                index++;
            }
        }

        return index;
    }
}