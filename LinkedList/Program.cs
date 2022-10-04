using System;
using System.Collections.Generic;

public class Program
{ // start of class Program
    public static void Main(string[] args)
    { // start of Main
        int[] num = { 1, 2, 3, 4, 5 };
        LinkedList<int> list = new LinkedList<int>(num);

        LinkedListNode<int> currentNode;

        // prints out a linked list
        void print_list(LinkedList<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

        // shows the current, previous, and next node
        void current_node_traits()
        { // start of current_node_traits
            if (currentNode == null)
            {
                Console.WriteLine("Node is null");
            }
            else
            {
                Console.WriteLine($"Current Node: {currentNode.Value}");

                if (currentNode.Previous == null) {
                    Console.WriteLine("This node is the head");
                }
                else {
                    Console.WriteLine($"Previous Node: {currentNode.Previous.Value}");
                }

                if(currentNode.Next == null) {
                    Console.WriteLine("This node is the tail");
                }
                else {
                    Console.WriteLine($"Next Node: {currentNode.Next.Value}");
                }
            }
        } // end of current_node_traits

        // prints a linked list in reverse
        void print_reverse(LinkedList<int> list)
        { // start of print_reverse
            currentNode = list.Last;
            
            Console.Write("Original List: ");
            foreach(int i in list)
            {
                Console.Write($"{i} ");
                //Console.WriteLine("");
            }

            Console.Write("\nReversed list: ");
            while(currentNode != null)
            {
                Console.Write($"{currentNode.Value} ");
                currentNode = currentNode.Previous;
            }
            Console.WriteLine("");
        } // end of print_reverse

        /*
        // find the middle node via the list's length
        void mid_point(LinkedList<int> list)
        { // start of mid_point
            currentNode = list.First;
            int tracker = 1;
            double length = list.Count;
            double mid = Math.Ceiling(length / 2);
            
            while(tracker != mid)
            {
                currentNode = currentNode.Next;
                tracker++;
            }

            Console.WriteLine($"The middle node is: {currentNode.Value}");
        } // end of mid-point
        */

        // Finds the middle node via two pointers whereas one travels twice as fast
        // as the other. Once the faster one reaches the end of the list, the other
        // will be at the middle point.
        void mid_point(LinkedList<int> list)
        {
            currentNode = list.First;
            LinkedListNode<int> flash = list.First;

            while(flash != list.Last && flash != null)
            {
                currentNode = currentNode.Next;
                flash = flash.Next.Next;
            }

            Console.WriteLine($"The middle node is: {currentNode.Value}");
        }

        print_reverse(list);

        mid_point(list);

        /*
        while (currentNode != null)
        {
            if(currentNode.Value == 4) { 
                list.AddAfter(currentNode, 9);
                break;
            }
            currentNode = currentNode.Next;
        }

        while (currentNode != null)
        {
            if(currentNode.Value == 5)
            {
                LinkedListNode<int> temp = currentNode;
                currentNode = currentNode.Next;
                list.Remove(temp);
                break;
            }
            else
            {
                currentNode = currentNode.Next;
            }
        }
        */

    } // end of Main
} // end of class Program