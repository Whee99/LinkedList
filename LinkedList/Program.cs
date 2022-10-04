using System;
using System.Collections.Generic;

public class Program
{ // start of class Program
    public static void Main(string[] args)
    { // start of Main
        int[] num = { 1, 2, 3, 4, 5 };
        LinkedList<int> list = new LinkedList<int>(num);

        LinkedListNode<int> currentNode = list.First;

        void print_list(LinkedList<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

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

        print_list(list);

        list.AddFirst(0);
        list.AddLast(6);

        print_list(list);

        current_node_traits();

        while (currentNode != null)
        {
            if(currentNode.Value == 4) { 
                list.AddAfter(currentNode, 9);
                break;
            }
            currentNode = currentNode.Next;
        }

        print_list(list);
        Console.WriteLine($"Current Node: {currentNode.Value}");

        while (currentNode != null)
        {
            if(currentNode.Value == 5)
            {
                LinkedListNode<int> temp = currentNode;
                currentNode = currentNode.Next;
                list.Remove(temp);
            }
            else
            {
                currentNode = currentNode.Next;
            }
        }

        print_list(list);

        current_node_traits();

        Console.WriteLine($"List's length: {list.Count}");
    } // end of Main
} // end of class Program