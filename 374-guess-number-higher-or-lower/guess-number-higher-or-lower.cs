/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return Verify(1, n);
    }

    public int Verify(int start, int end){
        if(start > end) return -1;
        
        int median = start + (end - start) / 2;
        int isCorrect = guess(median);

        if(isCorrect == 0)
            return median;
        
        else if(isCorrect == -1)
            return Verify(start, median - 1);
        
        else
            return Verify(median + 1, end);
    }
}