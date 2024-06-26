func maxArea(height []int) int {
    left, right := 0, len(height)-1
    maxWater := 0

    for left < right {
        width := right - left
        minHeight := height[left]
        if height[left] > height[right] {
            minHeight = height[right]
        }

        currentWater := width * minHeight
        if currentWater > maxWater {
            maxWater = currentWater
        }

        if height[left] < height[right] {
            left++
        } else {
            right--
        }
    }

    return maxWater
}
