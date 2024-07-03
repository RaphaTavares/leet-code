public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var hashmap = new Dictionary<int, int>();
        var maxOperations = 0;

        for(int i = 0; i < nums.Length; i++){
            var complement = k - nums[i];

            if(hashmap.ContainsKey(complement)){
                if(hashmap[complement] > 0){
                hashmap[complement]--;
                maxOperations++;
                continue;
                }
            }

            if(hashmap.ContainsKey(nums[i])){
                hashmap[nums[i]]++;
                continue;
            }

            hashmap[nums[i]] = 1;
        }

        return maxOperations;
    }
}