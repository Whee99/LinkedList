using System;
using System.Collections.Generic;

namespace LinkedList
{ // start of namespace
    public class Node
    { // start of Node
        public int data;
        public Node prev;
        public Node next;

        public Node(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    } // end of Node
} // end of namespace
