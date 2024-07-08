public class Solution {
    public int PivotIndex(int[] nums) {
        int leftSum = 0;
        int sum = 0;

        for(int i = 0; i < nums.Count(); i++){
            sum += nums[i];

        }
        
        Console.WriteLine($"sum: {sum}");

        for(int i = 0; i < nums.Count(); i++){
            if(sum - nums[i] - leftSum == leftSum)
                return i;
            
            leftSum += nums[i];
        }

        return -1;
    }
}