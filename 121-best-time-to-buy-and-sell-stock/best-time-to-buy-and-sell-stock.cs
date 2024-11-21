public class Solution {
    public int MaxProfit(int[] prices) {
        
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for(int i = 0; i < prices.Count(); i++){
            if(prices[i] < minPrice)
                minPrice = prices[i];

            else
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }

        return maxProfit;
    }
}