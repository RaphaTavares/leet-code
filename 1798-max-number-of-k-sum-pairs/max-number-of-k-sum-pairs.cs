public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var hashmap = new Dictionary<int, int>();
        var maxOperations = 0;

        foreach(var num in nums){
            var complement = k - num;

            if(hashmap.TryGetValue(complement, out var count) && count > 0){
                hashmap[complement]--;
                maxOperations++;
                continue;
            } 

            if(!hashmap.ContainsKey(num)){
            hashmap[num] = 0;
            }

            hashmap[num]++;
        }

        return maxOperations;
    }
}