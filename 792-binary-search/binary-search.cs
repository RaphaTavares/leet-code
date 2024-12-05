public class Solution {
    public int Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        while(start <= end){
            var mid = (end + start) / 2;
            Console.WriteLine("Mid:" + mid);
            if(nums[mid] > target)
                end = mid -1;
            else if(nums[mid] < target)
                start = mid + 1;
            else
                return mid;
        }
        
        return -1;
    }
}