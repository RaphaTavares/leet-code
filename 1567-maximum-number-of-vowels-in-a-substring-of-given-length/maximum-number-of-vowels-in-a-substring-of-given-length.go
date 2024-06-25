func maxVowels(s string, k int) int {
    maxVowels := 0
    currentVowels := 0

    for i := 0; i < k; i++{
        currentVowels += isVowel(s[i]) 
    }

    maxVowels = currentVowels

    for j := k; j < len(s); j++{

        currentVowels += isVowel(s[j])
        currentVowels -= isVowel(s[j-k])

        if currentVowels > maxVowels{
            maxVowels = currentVowels
        }
    }

    return maxVowels
}

func isVowel(c byte) int {
    switch c {
	case 97, 101, 105, 111, 117:
		return 1
	default:
		return 0
	}
}