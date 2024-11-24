public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;

        int left = 1;
        int right = x;

        int result = 0;

        while(left <= right){
            int mid = left + (right - left) / 2;

            long midXmid = (long)mid * mid;
            if(midXmid == x)
                return mid;

            else if(midXmid < x){
                left = mid + 1;
                result = mid;
            }

            else{
                right = mid - 1;
            }
        }
        return result;
    }
}