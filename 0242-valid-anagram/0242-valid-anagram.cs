public class Solution {
    public bool IsAnagram(string s, string t) {

        var isSameSize = s.Length == t.Length;

        if(!isSameSize)
            return false;

        for(var i = 0; i < s.Length; i++)
        {
            if(t.Contains(s[i])){
                var index = t.IndexOf(s[i]);

                t = t.Remove(index, 1);
            }
        }
        
        if(t.Length != 0)
            return false;
        
        return true;
    }
}