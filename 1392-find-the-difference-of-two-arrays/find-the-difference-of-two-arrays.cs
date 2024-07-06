using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var notIn1 = new HashSet<int>(set2);
        notIn1.ExceptWith(set1);

        var notIn2 = new HashSet<int>(set1);
        notIn2.ExceptWith(set2);

        return new List<IList<int>> { new List<int>(notIn2), new List<int>(notIn1) };
    }
}
