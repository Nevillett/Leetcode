using System;

namespace RemoveDuplicatesLinkedList2
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
            if (head == null && head.next == null) return head;
            Node newHead = new Node(0);
            newHead.next = head;
            Node Pre = newHead;
            Node Cur = newHead.next;

            while (Cur != null && Cur.next != null)
            {
                if( Cur.data == Cur.next.data )
                {
                    while ( Cur.next != null && Cur.data == Cur.next.data)
                    Cur = Cur.next;
                    Pre.next = Cur.next;
                } else {
                    //Pre.next = Cur;
                    Pre = Pre.next;
                }
                Cur = Cur.next;
            }
            return newHead.next;
        }
        
        public static void printList(Node head)
        {
            Node cur = head;
            while ( cur != null)
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
