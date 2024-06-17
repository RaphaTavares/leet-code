public class Solution {
    public void MoveZeroes(int[] nums) {
        
        for(int j = 0; j < nums.Length - 1; j++){
            for(int i = nums.Length - 1; i >= 0; i--){
                if(nums[i] == 0 && i < nums.Length - 1){
                    var temp = nums[i + 1];
                    nums[i + 1] = 0;
                    nums[i] = temp;
            }
        }
        }
        
    }
}