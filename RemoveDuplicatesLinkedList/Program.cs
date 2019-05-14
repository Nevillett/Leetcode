using System;

namespace RemoveDuplicatesLinkedList
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null;}
        }
        public static Node deleteDuplicates(Node head)
        {
            Node newHead = new Node(0);
            newHead.next = head;
            while (head != null && head.next != null) 
            {
                if (head.data == head.next.data)   
                    head.next = head.next.next;
                else head = head.next;
            } 
            return newHead.next; 
            // return one, now, head is at the end of the node.
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
            var result = deleteDuplicates(head);
            printList(result);
        }
    }
}
