using System;

namespace RemoveNthFromEnd
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null;}
        }

        public static Node RemoveNthFromEnd(Node head, int n)
        {
            Node start = new Node(0);
            start.next = head;
            Node fast = start;
            Node slow = start;
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }
            while(fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return start.next;
        }
        public static void printList(Node head)
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(3);
            head.next.next = new Node(6);
            head.next.next.next = new Node(8);
            head.next.next.next.next = new Node(5);

            printList(head);
            var result = RemoveNthFromEnd(head, 5);
            printList(result);
            var result2 = RemoveNthFromEnd(head, 1);
            printList(result2);
        }
    }
}
