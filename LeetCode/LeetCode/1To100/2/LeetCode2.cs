using System;

public class LeetCode2
{
    public static void Run()
    {
        ListNode l1 = new ListNode
        {
            val = 2,
            next = new ListNode
            {
                val = 3,
                next = new ListNode()
                {
                    val = 4,
                }
            }
        };

        ListNode l2 = new ListNode
        {
            val = 4,
            next = new ListNode
            {
                val = 3,
                next = new ListNode()
                {
                    val = 2,
                }
            }
        };
        Console.WriteLine(AddTwoNumbers(l1, l2));
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // 声明一个空链表
        ListNode result = null;

        //临时声明
        ListNode nodetemp = null;
        int num = 0;
        while (l1 != null || l2 != null)
        {
            int temp = (l1?.val ?? 0) + (l2?.val ?? 0) + num;
            num = temp / 10;
            ListNode node = new ListNode(temp % 10);
            if (result == null)
            {
                result = node;
                nodetemp = result;
            }
            else
            {
                nodetemp.next = node;
                nodetemp = nodetemp.next;
            }

            if (l1 != null)
            {
                l1 = l1.next;
            }

            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        if (num != 0)
        {
            nodetemp.next = new ListNode(num);
        }
        
        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}