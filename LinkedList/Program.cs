using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    { // start of class Program
        public static void Main(string[] args)
        { // start of Main
            
            // Prints a linked list
            void PrintList(LinkedList list)
            {
                Node temp = list.head;
                while(temp.next != null)
                {
                    Console.Write($"{temp.data} ");
                    temp = temp.next;
                }
            }
            
            // Get the last node of a linked list
            Node GetLastNode(LinkedList list)
            { // start of LastNode
                Node temp = list.head;                
                while(temp.next != null) { 
                    temp = temp.next;
                }
                return temp;
            } // end of LastNode

            // Finds a node in a linked list
            Node FindNode(LinkedList list, int i)
            {
                Node temp = list.head;
                while(temp.next != null) { 
                    if(temp.data == i) { 
                        return temp;
                    }
                    else {
                        temp = temp.next;
                    }
                }
                return temp;
            }
            
            // Inserts a node in front of a linked list
            void InsertFront(LinkedList list, int data)
            { // start of InsertFront
                Node newNode = new Node(data);
                newNode.next = list.head;
                newNode.prev = null;

                if(list.head != null) {
                    list.head.prev = newNode;
                }
                list.head = newNode;
            } // end of InsertFront

            // Inserts a node at the end of a linked list
            void InsertLast(LinkedList list, int data)
            { // start of InsertLast
                Node newNode = new Node(data);                
                if(list.head == null) {
                    newNode.prev = null;
                    list.head = newNode;
                    return;
                }
                Node lastNode = GetLastNode(list);
                lastNode.next = newNode;
                newNode.prev = lastNode;
            } // end of InsertLast

            // Creates a cycle within a linked list
            void Cycle(LinkedList list, int data)
            { // start of Cycle
                Node lastNode = GetLastNode(list);
                Node target = FindNode(list, data);

                if(target.data == data)
                {
                    lastNode.next = target;
                }
            } // end of Cycle

            // Detect if there is a cycle within the linked list
            bool TortoiseAndHare(LinkedList list)
            { // start of TortoiseAndHare
                if (list.head == null || list.head.next == null) { 
                    return false;
                }
                
                Node tortoise = list.head;
                Node hare = list.head.next;

                while(hare != null && hare.next != null)
                {
                    if(tortoise == hare) {
                        return true;
                    }
                    else { 
                        tortoise = tortoise.next;
                        hare = hare.next.next;
                    }
                }
                return false;
            } // end of TortoiseAndHare

            LinkedList list = new LinkedList();
            for(int i = 1; i <= 6; i++) {
                InsertLast(list, i);
            }

            PrintList(list);

            Cycle(list, 2);
            Console.WriteLine(FindNode(list, 5).next.data);
            
            

        } // end of Main
    } // end of class Program
}