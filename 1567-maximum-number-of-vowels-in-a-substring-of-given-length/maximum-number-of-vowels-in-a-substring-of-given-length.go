func maxVowels(s string, k int) int {
    maxVowels := 0
    currentVowels := 0

    for i := 0; i < k; i++{
        if(isVowel(s[i])){
            currentVowels++
        }
    }

    maxVowels = currentVowels

    for j := k; j < len(s); j++{
        if(isVowel(s[j])){
            currentVowels++
        }

        if(isVowel(s[j-k])){
            currentVowels--
        }

        if currentVowels > maxVowels{
            maxVowels = currentVowels
        }
    }

    return maxVowels
}

func isVowel(c byte) bool {
    if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'){
        return true
    }
    return false
}