//876. Middle of The Linked List
//Given the head of a singly linked list, return the middle node of the linked list.
//If there are two middle nodes, return the second middle node.

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

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        if (head == null) return null;

        Listnode middle = head;
        Listnode end = middle;

        while (end != null && end.next != null)
        {
            middle = middle.next;
            end = end.next.next;
        }

        return middle;
    }
}