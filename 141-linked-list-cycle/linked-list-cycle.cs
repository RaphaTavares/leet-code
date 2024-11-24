/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        var seen = new HashSet<ListNode>();
        
        while(head != null){
            if(seen.Contains(head))
                return true;

            seen.Add(head);

            head = head?.next;
        }

        return false;
    }
}