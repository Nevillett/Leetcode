using System;

namespace SwapNodesInPair
{
    class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) {data = d; next = null; }
        }
        void pairWiseSwap()
        {
            Node temp = head;
            while (temp != null && temp.next != null)
            {
                int k = temp.data;
                temp.data = temp.next.data;
                temp.next.data = k;
                temp = temp.next.next;
            }
        }
        //Inserts new Node at front of the list
        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        void printList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.head = new Node(10);
            list.head.next = new Node(20);
            list.head.next.next = new Node(15);
            list.head.next.next.next = new Node(25);
            // llist.push(5);
            // llist.push(4);
            // llist.push(3);
            // llist.push(2);
            // llist.push(1);

            Console.WriteLine("before");
            list.printList();
            list.pairWiseSwap();
            Console.WriteLine("after");
            list.printList();
        }
    }
}
