using System;

namespace DeleteNode
{
    class Program
    {
        public class Node
        {   
            public int data;
            public Node next;
            public Node(int d) {data = d; next = null;}
        }
        //actually delete the next one node... 
        //我们真正删除的是指定Node的下一个Node，然后把指定Node的Value更改成下一个Node的值罢了。
        //为什么这个node.next.next在这里是没问题的，因为题目告诉了说指定的Node不为Tail，所以我们不用担心这个Edge Case
        // Guess: given one node, only can delete the node after this one
        public static void DeleteOneNode(Node one)
        { 
            one.data = one.next.data;
            one.next = one.next.next;
        }
        public static void printList(Node head)
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            printList(head);
            var x = head.next;
            DeleteOneNode(x);
            printList(head);            
        }
    }
}
