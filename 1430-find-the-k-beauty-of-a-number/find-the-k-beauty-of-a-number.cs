public class Solution {
    public int DivisorSubstrings(int num, int k) {
        
        var strNum = num.ToString();
        
        var count = 0;

        for(int start = 0; start <= strNum.Length - k; start++){

            var subStr = strNum.Substring(start, k);

            if(isKBeauty(subStr, num, k))
                count++;    
        }

        return count;
    }

    public bool isKBeauty(string subNum, int num, int k){
        int intSubNum = Int32.Parse(subNum);

        return intSubNum != 0 && num % intSubNum == 0;
    }
}