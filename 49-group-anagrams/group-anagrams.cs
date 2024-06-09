public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var anagramGroups = new Dictionary<string, List<string>>();

        var usedIndexes = new List<int>();

        for(var i = 0; i < strs.Length; i++)
        {
            var orderedStr = new string(strs[i].OrderBy(x => x).ToArray());

            if(!anagramGroups.ContainsKey(orderedStr))
                anagramGroups.Add(orderedStr, new List<string>(){strs[i]});

            else
                anagramGroups[orderedStr].Add(strs[i]);
        }

        return anagramGroups.Values.ToList<IList<string>>();
    }
}