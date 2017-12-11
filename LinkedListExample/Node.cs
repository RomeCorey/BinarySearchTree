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
        public int value;
        public Node()
        {

        }

        public int GetInitial
        {
            get
            {
                return value;          
            }
            set
            {

            }
        }

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }
}
    
       
    






// binary search tree
// add method
// search method that will also track the path