public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            int[] charCount = new int[26];
            foreach(var c in str){
                charCount[c - 'a']++;
            }

            var key = string.Join("#", charCount);

            if(!anagramGroups.ContainsKey(key))
                anagramGroups.Add(key, new List<string>(){str});

            else
                anagramGroups[key].Add(str);
        }

        return anagramGroups.Values.ToList<IList<string>>();
    }
}