using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5 };
        LinkedList<int> list = new LinkedList<int>(num);

        LinkedListNode<int> currentNode = list.First;

        foreach (int i in list)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");

        list.AddFirst(0);
        list.AddLast(6);

        foreach (int i in list)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");

        while (currentNode != null)
        {
            if(currentNode.Value == 4) { 
                list.AddAfter(currentNode, 9);
                break;
            }
            currentNode = currentNode.Next;
        }

        foreach (int i in list)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");

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

        foreach (int i in list)
        {
            Console.Write($"{i} ");
        }
    }
}