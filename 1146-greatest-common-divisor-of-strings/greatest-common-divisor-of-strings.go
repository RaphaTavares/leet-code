import (
    "strings"
)

func gcdOfStrings(str1 string, str2 string) string {
    if strings.Compare(str1 + str2, str2 + str1) != 0 {
        return ""
    }

    gcdLength := GCDLength(len(str1), len(str2))

    return str1[0 : gcdLength]
}

func GCDLength(a int , b int) int {
    if b == 0 {
        return a
    }

    return GCDLength(b , a % b)
}