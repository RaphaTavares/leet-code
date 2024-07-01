/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        
        var size = GetSize(head);

        if(size == 1)
            return null;

        var count = 0;

        ListNode current = head;
        ListNode previous = null;
        
        while(count != size / 2){
            previous = current;
            current = current.next;
            count++;
        }

        previous.next = current.next;

        return head;
    }

    public int GetSize(ListNode head){
        var count = 1;
        ListNode current = head;

        while(current.next != null){
            current = current.next;
            count++;
        }

        return count;
    }
}