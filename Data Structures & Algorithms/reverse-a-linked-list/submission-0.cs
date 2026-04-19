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
    public ListNode ReverseList(ListNode head) {
        if (head == null){
            return head;
        }

        var newListNode = new ListNode();
        var stack = new Stack<ListNode>();
        var current = head;

        stack.Push(current);
        while(current.next != null){
            current = current.next;
            stack.Push(current);
        }

        newListNode = stack.Pop();
        current = newListNode;
        while(stack.Count != 0){
            if (stack.Count == 1)
            {
                newListNode.next = stack.Pop();
                newListNode = newListNode.next;
                newListNode.next = null;
                break;
            }
            newListNode.next = stack.Pop();
            newListNode = newListNode.next;
        }

        return current;
    }
}
