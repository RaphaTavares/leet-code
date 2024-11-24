public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        var start = 0;
        var mid = n;
        int[] result = new int[n*2];

        for(int i = 0; i < n*2; i+=2){
            result[i] = nums[start++];
            result[i+1] = nums[mid++];
        }

        return result;
    }
}