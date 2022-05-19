using System.Collections.Generic;
using LeetCode;

namespace AlgorithmII.Day07
{
    public class PopulatingNextRightPointersInEachNode
    {
        public static void Run()
        {
            var result = new PopulatingNextRightPointersInEachNode().Connect(Node.BuildBinaryTree());
        } 
        public Node Connect(Node root)
        {
            if (root == null) return null;
            
            var curP = root;
            var nextDummyHead = new Node(0);
            var p = nextDummyHead;
            while (curP != null)
            {
                if (curP.left != null)
                {
                    p.next = curP.left;
                    p = p.next;
                }

                if (curP.right != null)
                {
                    p.next = curP.right;
                    p = p.next;
                }

                if (curP.next != null)
                {
                    curP = curP.next;
                }
                else
                {
                    curP = nextDummyHead.next;
                    nextDummyHead.next = null;
                    p = nextDummyHead;
                }
            }

            return root;
        }
    }
}