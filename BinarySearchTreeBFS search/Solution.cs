using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BinarySearchTreeBFS_search
{
    class Node
    {
        public Node left,right;
        public int data;
        public Node(int data){
            this.data=data;
            left=right=null;
        }
    }
    class Solution
    {
        //Thanks @LEisenstein !!!! 
        //I was having a lot of trouble implementing a Level-Order          //Traversal (BFS), your solution was very helpful.
        static Queue<Node> nodeQ = new Queue<Node>();
	    static void levelOrder(Node root)
        {
  		    //Write your code here
            nodeQ.Enqueue(root);
            while (nodeQ.Count > 0)
            {
                var n = nodeQ.Dequeue();
                Console.Write(n.data + " ");
                if (n.left != null)
                    nodeQ.Enqueue(n.left);
                if (n.right != null)
                 nodeQ.Enqueue(n.right);
            }
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
            levelOrder(root);
        }
    }
}