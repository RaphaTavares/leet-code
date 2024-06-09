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

public static class ExtensionMethods {
        public static bool IsAnagram(this string firstString, string secondString)
{
    if(firstString.Length != secondString.Length)
        return false;

    int[] charCount = new int[26];

    for(var i = 0; i < firstString.Length; i++){
        charCount[firstString[i] - 'a']++;
        charCount[secondString[i] - 'a']--;
    }

    for(var i = 0; i < charCount.Length; i++)
    {
        if(charCount[i] != 0)
            return false;
    }

    return true;
}
}
