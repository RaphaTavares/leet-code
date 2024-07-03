public class Solution {
    public string ReverseVowels(string s) {
        int left = 0, right = s.Length -1; 
        var characters = s.ToCharArray();

        while(left < right){
            if(!IsVowel(characters[left]))
                left++;

            else if(!IsVowel(characters[right]))
                right--;
        
            else {
                var temp = characters[left];
                characters[left] = characters[right];
                characters[right] = temp;
                left++;
                right--;
            }
        }

        return new string(characters);
    }

    public bool IsVowel(char c){
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }
}