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
                while(temp != null)
                {
                    Console.Write($"{temp.data} ");
                    temp = temp.next;
                }
                Console.WriteLine("");
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
            // Start of FindNode
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
                return null;
            }
            // End of FindNode

            // Removes a node from a Linked List
            // Start of RemoveNode
            void RemoveNode(LinkedList list, int data)
            {
                Node temp = FindNode(list, data);
                if(temp == null) {
                    Console.WriteLine("Node does not exist");
                }
                else {
                    if(temp == list.head) {
                        Node next = temp.next;
                        next.prev = null;
                        temp = null;
                    }
                    else if(temp == GetLastNode(list)) {
                        Node previous = temp.prev;
                        previous.next = null;
                        temp = null;
                    }
                    else {
                        Node previous = temp.prev;
                        Node next = temp.next;
                        previous.next = next;
                        next.prev = previous;
                        temp = null;
                    }
                }
            }
            // End of RemoveNode
            
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

            // Adds an item to the front of a list
            // Start of enQueue
            void enQueue(LinkedList queue, int data)
            {
                InsertFront(queue, data);
            }
            // End of enQueue

            // Remove an item from the end of the list
            // start of deQueue
            void deQueue(LinkedList queue)
            {
                RemoveNode(queue, GetLastNode(queue).data);
            }
            // end of deQueue

            // Creates a cycle within a linked list
            void Cycle(LinkedList list, int data1, int data2)
            { // start of Cycle
                Node start = FindNode(list, data1);
                Node end = FindNode(list, data2);              

                if (start != null && end != null) {
                    start.next = end;
                }
                else {
                    Console.WriteLine("The node(s) is null");
                }
            } // end of Cycle

            // Cycle detection algorithm
            bool TortoiseAndHare(LinkedList list)
            { // start of TortoiseAndHare
                if (list.head == null || list.head.next == null) {
                    Console.WriteLine("List is empty");
                    return false;
                }
                
                Node tortoise = list.head;
                Node hare = list.head.next;

                while(hare != null && hare.next != null)
                {
                    if(tortoise == hare) {
                        Console.WriteLine("Cycle found!");
                        return true;
                    }
                    else { 
                        tortoise = tortoise.next;
                        hare = hare.next.next;
                    }
                }
                Console.WriteLine("Cycle not found");
                return false;
            } // end of TortoiseAndHare

            LinkedList list = new LinkedList();
            for(int i = 1; i <= 10; i++) {
                InsertLast(list, i);
            }

            PrintList(list);

            Cycle(list, 8, 2);
            Console.WriteLine(FindNode(list, 8).next.data);

            TortoiseAndHare(list);
            Console.WriteLine(TortoiseAndHare(list));
        } // end of Main
    } // end of class Program
}