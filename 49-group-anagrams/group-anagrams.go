
import ( "fmt"
         "strings"
)

func groupAnagrams(strs []string) [][]string {
    
    anagramGroups := make(map[string][]string)

    for _, str := range strs{
        charCount := make([]int, 26)

        for _, c := range str{
            charCount[c - 'a']++
        }

        key := strings.Trim(strings.Replace(fmt.Sprint(charCount), " ", "#", -1), "[]")


        if _, exists := anagramGroups[key]; !exists {
            anagramGroups[key] = []string{str}
        } else{
            anagramGroups[key] = append(anagramGroups[key], str)
        }
    }

    result := make([][]string, 0, len(anagramGroups))
    for _, group := range anagramGroups {
        result = append(result, group)
    }

    return result
}