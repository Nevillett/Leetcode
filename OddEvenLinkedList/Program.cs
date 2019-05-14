using System;

namespace OddEvenLinkedList
{
    class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null;}   
        }
        public Node OddEvenSwap()
        {
            if (head == null)
            return head;

            Node pre = head;
            Node cur = head.next;
            Node connectNode = head.next;
            while(pre != null & cur != null)
            {
                pre.next = cur.next;
                pre = pre.next;
                cur.next = pre.next;
                cur = cur.next;
            }
            pre.next = connectNode;
            return head;
        }
        void printList()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data+ "->");
                current = current.next;
            }
            Console.WriteLine("NULL");
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(1);
            list.head.next = new Node(2);
            list.head.next.next = new Node(3);
            list.head.next.next.next = new Node(4);
            list.head.next.next.next.next = new Node(5);

            Console.WriteLine("before");
            list.printList();
            list.OddEvenSwap();
            list.printList();

        }
    }
}
