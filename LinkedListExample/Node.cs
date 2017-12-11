using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Node
    {
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }


        public void Add(int value)
        {

            if (top == null)
            {
                Node NewNode = new Node(value);
                top = NewNode;
                return;
            }
            Node currentNode = top;
            bool added = false;
            do
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node NewNode = new Node(value);
                        currentNode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node NewNode = new Node(value);
                        currentNode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
     }
    
       
    






// binary search tree
// add method
// search method that will also track the path