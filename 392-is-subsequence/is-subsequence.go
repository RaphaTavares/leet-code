func isSubsequence(s string, t string) bool {
    currentIndex := 0
    maxIndex := len(s)

    for i := 0; i < len(t); i++ {
        if currentIndex == maxIndex {
            return true
        }
        
        if s[currentIndex] == t[i]{
            currentIndex++
        }
    }

    if currentIndex == maxIndex {
            return true
        }
    return false

}