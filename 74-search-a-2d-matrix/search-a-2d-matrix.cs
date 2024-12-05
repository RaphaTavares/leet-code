public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var firstStart = 0;
        var firstEnd = matrix.Length - 1;

        while(firstStart <= firstEnd){
            var firstMid = (firstStart + firstEnd) / 2;

            Console.WriteLine($"FirstMid: {firstMid}");

            if(target > matrix[firstMid][^1])
                firstStart = firstMid + 1;
            else if(target < matrix[firstMid][0])
                firstEnd = firstMid - 1;
            else{

                var secondStart = 0;
                var secondEnd = matrix[firstMid].Length - 1;
                
                while(secondStart <= secondEnd){
                    var secondMid = (secondStart + secondEnd) / 2;

                    if(target > matrix[firstMid][secondMid])
                        secondStart = secondMid + 1;
                    else if(target < matrix[firstMid][secondMid])
                        secondEnd = secondMid - 1;
                    else
                        return true;
                }

                return false;
            }
        }
        return false;
    }
}