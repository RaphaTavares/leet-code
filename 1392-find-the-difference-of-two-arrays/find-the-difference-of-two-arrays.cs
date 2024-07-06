public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var notIn1 = new List<int>();
        var notIn2 = new List<int>();
        

        foreach(var num in nums2){
            var setSize = set1.Count();

            set1.Add(num);

            if(setSize != set1.Count())
                notIn1.Add(num);
        }

        foreach(var num in nums1){
            var setSize = set2.Count();

            set2.Add(num);

            if(setSize != set2.Count())
                notIn2.Add(num);
        }

        List<IList<int>> result = new();

        result.Add(notIn2);
        result.Add(notIn1);

        return result;
    }
}