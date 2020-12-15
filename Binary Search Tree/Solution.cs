using System;

namespace Binary_Search_Tree
{
//Example program for demonstrating a getHeight() function
//in a binary search tree, by examining depth.
//The following is suggested sample input.
//7 -- int T, which is the number of Nodes to be created.
//The program will read T new lines of input before running.
//The following is data per node which is stored into the
//indexed tree. Reads each line as an individual int to be stored.
//3
//5
//2
//1
//4
//6
//7
    class Node
    {
        public Node left,right;
        public int data;
        public Node(int data)
        {
            this.data=data;
            left=right=null;
        }
    }

    class Solution
    {
	    static int getHeight(Node root)
        {
        //Write your code here
        
            if (root == null)
            {
                return -1;
            }
        
            return 1+Math.Max(getHeight(root.left), getHeight(root.right));
        }
	    static Node insert(Node root, int data)
        {
            if(root==null)
            {
                return new Node(data);
            } 
            else 
            {
                Node cur;

                if(data<=root.data)
                {
                    cur=insert(root.left,data);

                    root.left=cur;
                }
                else
                {
                    cur=insert(root.right,data);

                    root.right=cur;
                }

            return root;
            }
        }
        static void Main(String[] args)
        {
            Node root=null;

            int T=Int32.Parse(Console.ReadLine());

            while(T-->0)
            {
                int data=Int32.Parse(Console.ReadLine());

                root=insert(root,data);            
            }

            int height=getHeight(root);

            Console.WriteLine(height);
        }
    }
}
