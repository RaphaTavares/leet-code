
import (
	"fmt"
	"math"
)

func asteroidCollision(asteroids []int) []int {
    var remainingAsteroids []int

    remainingAsteroids = append(remainingAsteroids, asteroids[0])

    for i:= 1; i < len(asteroids); i++ {
        if len(remainingAsteroids) == 0{
            remainingAsteroids = append(remainingAsteroids, asteroids[i])
            continue
        }

        if asteroids[i] > 0 {
                remainingAsteroids = append(remainingAsteroids, asteroids[i])
            } else if asteroids[i] < 0 {
            if goesLeft(remainingAsteroids[len(remainingAsteroids)-1]) {
                remainingAsteroids = append(remainingAsteroids, asteroids[i])
            } else {

            

            count := len(remainingAsteroids)
            asteroidExploded := false

            for count > 0 && !goesLeft(remainingAsteroids[len(remainingAsteroids)-1]){

                fmt.Printf("porra aqui: %d", remainingAsteroids[len(remainingAsteroids)-1])
                if int(math.Abs(float64(asteroids[i]))) > remainingAsteroids[count-1] {
                            fmt.Println("ola")
                    remainingAsteroids = remainingAsteroids[:count-1]
                } else if int(math.Abs(float64(asteroids[i]))) == remainingAsteroids[count-1] {
                            fmt.Println("oi")
                    remainingAsteroids = remainingAsteroids[:count-1]
                    asteroidExploded = true
                    break
                } else if int(math.Abs(float64(asteroids[i]))) < remainingAsteroids[count-1] {
                            fmt.Println("eai")
                    asteroidExploded = true
                    break
                }   
                count--
            }
            if !asteroidExploded {
                remainingAsteroids = append(remainingAsteroids, asteroids[i])
            }
            }
        }
    }

    return remainingAsteroids
}

func goesLeft(asteroid int) bool {
    return asteroid < 0
}