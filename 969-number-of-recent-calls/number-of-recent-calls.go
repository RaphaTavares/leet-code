import "container/list"

type RecentCounter struct {
    times *list.List
}


func Constructor() RecentCounter {
    return RecentCounter{times: list.New()}
}


func (this *RecentCounter) Ping(t int) int {
    this.times.PushBack(t)

    for this.times.Len() > 0 && this.times.Front().Value.(int) < t-3000{
        this.times.Remove(this.times.Front())
    }

    return this.times.Len()
}


/**
 * Your RecentCounter object will be instantiated and called as such:
 * obj := Constructor();
 * param_1 := obj.Ping(t);
 */