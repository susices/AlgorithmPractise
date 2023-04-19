namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ2
{
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next; 
      }
    }
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        ListNode preNode = null;

        bool addOne = false;
        while (!(l1==null && l2==null && !addOne))
        {
            ListNode curNode = new ListNode();
            int value1 = 0,value2 = 0;
            
            if (l1!=null)
            {
                value1 = l1.val;
                l1 = l1.next;
            }

            if (l2!=null)
            {
                value2 = l2.val;
                l2 = l2.next;
            }

            int result = value1 + value2 + (addOne ? 1 : 0);
            if (result>=10)
            {
                addOne = true;
                result -= 10;
            }
            else
            {
                addOne = false;
            }

            if (preNode!=null)
            {
                preNode.next = curNode;
            }
            else
            {
                curNode = head;
            }
            curNode.val = result;
            preNode = curNode;
        }
        return head;
    }
}