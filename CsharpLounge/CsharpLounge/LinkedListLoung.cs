using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLounge
{
    class LinkedListLoung
    {


        
 
public class Solution
        {


            ListNode listnode = new ListNode(1);
            
            public ListNode OddEvenList(ListNode head)
            {
                
                
                return head;
            }
        }
    }

   
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
       
        public ListNode()
        {
          
        }


        public ListNode reversell(ListNode head)
        {

            ListNode reversedPart = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode next = current.next;
                current.next = reversedPart;
                reversedPart = current;
                current = next;
            }
            head = reversedPart;
            return head;
        }

        public ListNode OddEvenList(ListNode head)
        {
            ListNode oddposition = new ListNode(1);
            ListNode evenposition = new ListNode(2);
            ListNode oddStart;
            ListNode evenStart;
            bool isodd = false;

            if (head == null || head.next == null) return head;

            oddposition = head;
            oddStart = head;

            head = head.next;
            evenposition = head;
            evenStart = head;

            while (head.next != null)
            {
                head = head.next;
                isodd = !isodd;

                if (isodd)
                {
                    oddposition.next = head;
                    oddposition = head;
                }
                else
                {
                    evenposition.next = head;
                    evenposition = head;
                }


            }
            oddposition.next = evenStart;
            evenposition.next = null;
            return oddStart;
        }
        public ListNode oddEvenList(ListNode head)
        {
            if (head == null) return head;
            ListNode p = head, q = head;
            while (q != null)
            {
                q = q.next;
                if (q == null || q.next == null) break;
                ListNode next_p = p.next, next_q = q.next;
                q.next = next_q.next;
                p.next = next_q;
                next_q.next = next_p;
                p = p.next;
            }
            return head;
        }
      
        //public ListNode oddEvenList(ListNode head)
        //{
        //    if (head == null) return null;
        //    ListNode node = head;

        //    ListNode newNode = new ListNode();
        //    while (node.next != null)
        //    {
        //        if (node.val % 2 != 0)
        //        {
        //            newNode.AddToTail(node.val);
        //        }
        //        node = node.next;
        //        if (node.next == null)
        //        {
        //            newNode.AddToTail(node.val);
        //        }
        //    }

        //    while (head.next != null)
        //    {
        //        if (head.val % 2 == 0)
        //        {
        //            newNode.AddToTail(head.val);
        //        }
        //        head = head.next;
        //        if (head.next == null)
        //        {
        //            newNode.AddToTail(head.val);
        //        }
        //    }
        //    return newNode;

        //}
        public void AddToTail(int val)
        {
            ListNode newNode = new ListNode(val);
            ListNode current = this;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode; 

        }
    }
}
