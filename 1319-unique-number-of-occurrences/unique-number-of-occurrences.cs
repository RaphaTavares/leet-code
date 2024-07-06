public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var map = new Dictionary<int, int>();

        foreach(var num in arr){
            if(map.ContainsKey(num))
                map[num] += 1;
            else
                map.Add(num, 1);
            Console.WriteLine(map[num]);
        }

        var set = new HashSet<int>();

        foreach(var item in map){
            var setSize = set.Count();

            set.Add(item.Value);

            if(setSize == set.Count())
                return false;
        }

        return true;
    }
}