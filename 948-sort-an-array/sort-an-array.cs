public class Solution {
    public int[] SortArray(int[] nums) {
     var negative = new int[50001];
     var positive = new int[50001];
     var result = new int[nums.Length];

     for(int i = 0; i < nums.Length; i++){
        if(nums[i] >= 0)
            positive[nums[i]]++;
        else
            negative[Math.Abs(nums[i])]++;
     }

     int index = 0;

     for(int i = negative.Length - 1; i > 0; i--){
        for(int j = 0; j < negative[i]; j++){
            result[index++] = -i;
        }
     }

     for(int i = 0; i < positive.Length; i++){
        for(int j = 0; j < positive[i]; j++){
            result[index++] = i;
        }
     }

     return result;
    }
}