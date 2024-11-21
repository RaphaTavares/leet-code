public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stack = new();

        Dictionary<char, char>  mapping = new Dictionary<char, char>{
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach(char ch in s){
            if(mapping.TryGetValue(ch, out char expected)){
                if(stack.Count == 0 || stack.Pop() != expected)
                    return false;
            }
            else
                stack.Push(ch);
        }

        return stack.Count() == 0;

    }

    public bool IsOpening(char ch){
        return ch == '(' || ch == '[' || ch == '{';
    }
}