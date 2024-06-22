
import "math"
func findMaxAverage(nums []int, k int) float64 {
    
    biggestSumOfKElements := math.MinInt64;

    for i := 0; i <= len(nums) - k; i++ {
        sumOfKElements := 0

        for j := 0; j < k; j++ {
            sumOfKElements += nums[i+j]
        }

        if sumOfKElements > biggestSumOfKElements{
            biggestSumOfKElements = sumOfKElements
        }
    }

    return float64(biggestSumOfKElements) / float64(k)
} 