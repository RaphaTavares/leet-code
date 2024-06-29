func removeStars(s string) string {
    var stack []byte

    for i := 0; i < len(s); i++{
        if(s[i] != '*'){
            stack = append(stack, s[i])
        } else {
            stack = append(stack[: len(stack)-1])
        }
    }
        return string(stack)
}