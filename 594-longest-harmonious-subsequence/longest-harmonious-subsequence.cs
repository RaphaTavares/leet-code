public class Solution {
    public int FindLHS(int[] nums) {
        
        var numberCount = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(numberCount.ContainsKey(nums[i]))
                numberCount[nums[i]]++;

            else
                numberCount[nums[i]] = 1;
        }

        var lhs = 0;

        foreach(var key in numberCount.Keys){
            if(numberCount.ContainsKey(key+1)){
                var current = numberCount[key];
                var next = numberCount[key+1];
                if(current+next > lhs)
                    lhs = current+next;
            }
        }

        return lhs;
    }
}