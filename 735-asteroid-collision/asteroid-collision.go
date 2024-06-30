
import (
	"math"
)

func asteroidCollision(asteroids []int) []int {
    var remainingAsteroids []int
    for _, asteroid := range asteroids {
        exploded := false

        for len(remainingAsteroids) > 0 && remainingAsteroids[len(remainingAsteroids)-1] > 0 && asteroid < 0 {

            top := remainingAsteroids[len(remainingAsteroids)-1]

            if math.Abs(float64(asteroid)) > float64(top) {
                remainingAsteroids = remainingAsteroids[:len(remainingAsteroids)-1]    
            } else if math.Abs(float64(asteroid)) == float64(top) {
                exploded = true
                remainingAsteroids = remainingAsteroids[:len(remainingAsteroids)-1]
                break
            } else {
                exploded = true
                break
            }
        }

        if !exploded {
            remainingAsteroids = append(remainingAsteroids, asteroid)
        } 
    }

    return remainingAsteroids
}

