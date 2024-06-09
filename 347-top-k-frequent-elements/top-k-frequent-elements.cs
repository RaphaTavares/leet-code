public class Solution {
        public int[] TopKFrequent(int[] nums, int k) {
        var numbersFrequency = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if(numbersFrequency.ContainsKey(num))
                numbersFrequency[num]++;
            else 
                numbersFrequency[num] = 1;
        }


        var sortedElements = numbersFrequency.OrderByDescending(x => x.Value).  Select(x => x.Key).ToList();

        return sortedElements.Take(k).ToArray();

    }
}