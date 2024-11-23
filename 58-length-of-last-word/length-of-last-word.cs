public class Solution {
    public int LengthOfLastWord(string s) {
        
        var words = s.Trim().Split(' ');
        return words[^1].Length;
    }
}