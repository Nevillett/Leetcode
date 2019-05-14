using System;

namespace RemoveElementsLinkedList203
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null;}
        }
        public static Node removeElements(Node head, int val)
        {
            Node newHead = new Node(0);
            newHead.next = head;
            Node pre = newHead;
            Node cur = newHead.next;
            
            while( cur != null )
            {
                if (cur.data == val)
                {
                    pre.next = cur.next;
                } else {
                    pre = cur;
                }
                cur = cur.next; //
            }
            return newHead.next; //
        }

        public static void printList(Node head)
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(3);
            head.next.next = new Node(3);
            head.next.next.next = new Node(3);
            head.next.next.next.next = new Node(5);
            head.next.next.next.next.next = new Node(5);
            head.next.next.next.next.next.next = new Node(8);
            
            printList(head);
            var result = removeElements(head, 5);
            printList(result);
        }
    }
}

// recursive ??  JAVA
// public ListNode removeElements(ListNode head, int val) {
//         if (head == null) return null;
//         head.next = removeElements(head.next, val);
//         return head.val == val ? head.next : head;
// }


