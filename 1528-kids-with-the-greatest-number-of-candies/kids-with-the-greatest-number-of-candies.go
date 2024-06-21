func kidsWithCandies(candies []int, extraCandies int) []bool {
    maxCandies := 0;

    for i := 0; i < len(candies); i++ {
        if(candies[i] > maxCandies){
            maxCandies = candies[i]
        }
    }

    var output []bool;

    for i := 0; i < len(candies); i++ {
        if maxCandies <= (candies[i] + extraCandies) {
            output = append(output, true)
        } else {
            output = append(output, false)
        }
    }

    return output
}