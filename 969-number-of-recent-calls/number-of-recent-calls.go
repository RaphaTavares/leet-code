type RecentCounter struct {
    CountsTime []int
}


func Constructor() RecentCounter {
    return RecentCounter{CountsTime: []int{}}
}


func (this *RecentCounter) Ping(t int) int {
    this.CountsTime = append(this.CountsTime, t)

    for len(this.CountsTime) > 0 && this.CountsTime[0] < t-3000{
        this.CountsTime = this.CountsTime[1:]
    }

    return len(this.CountsTime)
}


/**
 * Your RecentCounter object will be instantiated and called as such:
 * obj := Constructor();
 * param_1 := obj.Ping(t);
 */