using System;

namespace LinkedListCycle
{
    public class LinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null;}
        }

        public Boolean hasCycle()
        {
            if(head == null) return false;
            Node walker = head;
            Node runner = head;
            while(runner.next != null && runner.next.next != null)
            {
                walker = walker.next;
                runner = runner.next.next;
                if (walker == runner) 
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(10);
            list.head.next = new Node(20);
            list.head.next.next = new Node(15);
            //list.head.next.next.next = list.head;
            list.head.next.next.next = new Node(25);
            var flag = list.hasCycle();
            if (flag) 
            Console.WriteLine("yes,this linkedlist has cycle.");
            else
            Console.WriteLine("do not have cycle.");
        }
    }
}

