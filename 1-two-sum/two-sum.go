func twoSum(nums []int, target int) []int {
    
    numMap := make(map[int]int)

    for i, num := range nums{
        complement := target - nums[i]

        if index, ok := numMap[complement]; ok{
            return []int{index, i}
        }
        numMap[num] = i
    }

    return nil
}