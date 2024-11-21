public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stack = new();

        Dictionary<char, char>  mapping = new Dictionary<char, char>{
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        foreach(char ch in s){
            if(IsOpening(ch))
                stack.Push(ch);
            
            else if(mapping.ContainsKey(ch)){
                if(stack.Count == 0)
                    return false;
                    
                var topOfStack = stack.Pop();

                if(topOfStack != mapping[ch])
                    return false;
            }
        }

        return stack.Count() == 0 ? true : false;

    }

    public bool IsOpening(char ch){
        return ch == '(' || ch == '[' || ch == '{';
    }
}