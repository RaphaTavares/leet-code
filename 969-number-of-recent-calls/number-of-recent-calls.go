type RecentCounter struct {
    CountsTime []int
}


func Constructor() RecentCounter {
    return RecentCounter{}
}


func (this *RecentCounter) Ping(t int) int {
    this.CountsTime = append(this.CountsTime, t)

    result := 0

    for i := 0; i < len(this.CountsTime); i++ {
        if this.CountsTime[i] >= t - 3000 && this.CountsTime[i] <= t {
            result++
        }
    }

    return result
}


/**
 * Your RecentCounter object will be instantiated and called as such:
 * obj := Constructor();
 * param_1 := obj.Ping(t);
 */