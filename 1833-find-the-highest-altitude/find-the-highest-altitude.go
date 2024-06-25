func largestAltitude(gain []int) int {
    highestAltitude := 0
    currentAltitude := 0


    for i := 0; i < len(gain); i++ {
        currentAltitude += gain[i]

        if(currentAltitude > highestAltitude){
            highestAltitude = currentAltitude
        }
    }

    return highestAltitude
}