func canPlaceFlowers(flowerbed []int, n int) bool {
    count := 0
    length := len(flowerbed)
    for i := 0; i < length; i++ {

        fmt.Printf("i: %d", i)
        
        if flowerbed[i] == 0 {
            prevEmpty := (i == 0) || (flowerbed[i-1] == 0)
            nextEmpty := (i == length-1) || (flowerbed[i+1] == 0)

            if prevEmpty && nextEmpty {
                flowerbed[i] = 1
                count++
                if count >= n {
                return true
                }
                i++
            }
        }
    }

    return count >= n
}