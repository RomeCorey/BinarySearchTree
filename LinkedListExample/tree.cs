using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
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
            Node currentNode = top;
            bool added = false;

            if (top == null)
            {
                Node NewNode = new Node(value);
                top = NewNode;
                return;
            }

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
            } while (!added);
        }

        public bool Search(int value)
        {
            Node currentNode = top;
            
            
                while (currentNode != null)
                {
                    if (currentNode.value == value)
                    {
                        return true;
                    }
                    else if (currentNode.value < value)
                    {
                        currentNode = currentNode.right;
                       
                    }
                    else if (currentNode.value > value)
                    {
                        currentNode = currentNode.left;
                    }                
            }
            return false;
        }
    }
}
    
            
        
            
