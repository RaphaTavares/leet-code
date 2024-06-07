public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();

        for(var i = 0; i < s.Length; i++)
        {
            if(countS.ContainsKey(s[i])){
                countS[s[i]] += 1;
            }
            else{
                countS[s[i]] = 1;
            }

            if(countT.ContainsKey(t[i])){
                countT[t[i]] += 1;
            }
            else{
                countT[t[i]] = 1;
            }
        }
        
        foreach(var key in countS.Keys){
            if(!countT.ContainsKey(key) || countT[key] != countS[key])
                return false;
        }
        
        return true;
    }
}