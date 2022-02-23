using System;
using System.Collections.Generic;

namespace RightViewOfBinaryTree
{
    class Node
    {
        public int val;
        public Node left, right;
    }
    class Program
    {
        public IList<int> RightSideView(Node root)
        {
            List<int> rightSideValues = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for(int i = 0; i < size; i++)
                {
                    var currentVal = queue.Dequeue();
                    if (i == 0)
                        rightSideValues.Add(currentVal.val);
                    if (currentVal.right != null)
                        queue.Enqueue(currentVal.right);
                    if (currentVal.left != null)
                        queue.Enqueue(currentVal.left);
                    
                }
            }
            return rightSideValues;
        }
            static Node newNode(int data)
        {
            Node temp = new Node();
            temp.val = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }
        static void Main(string[] args)
        {
            Node root = null;
            root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.right = newNode(5);
            root.right.right = newNode(4);
            Program p = new Program();
          IList<int> result =  p.RightSideView(root);
            foreach (var i in result)
                Console.Write(i + " ");

        }
    }
}
