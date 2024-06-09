public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        IList<IList<string>> result = new List<IList<string>>();
        
        for (int i = 0; i < strs.Length; i++) {
            bool added = false;
            
            foreach (var group in result) {
                if (IsAnagram(group[0], strs[i])) {
                    group.Add(strs[i]);
                    added = true;
                    break;
                }
            }
            
            if (!added) {
                result.Add(new List<string> { strs[i] });
            }
        }
        
        return result;
    }
    

    private bool IsAnagram(string s1, string s2) {
        if (s1.Length != s2.Length) return false;
        
        var count = new int[26];
        foreach (var c in s1) count[c - 'a']++;
        foreach (var c in s2) {
            if (--count[c - 'a'] < 0) return false;
        }
        
        return true;
    }
}


