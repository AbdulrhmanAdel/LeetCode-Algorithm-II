using System;
using LeetCode;

namespace AlgorithmII.Day07
{
    public class SubtreeOfAnotherTree
    {
        public static void Run()
        {
            var result = new SubtreeOfAnotherTree()
                .IsSubtree(TreeNode.GetTreeStaticValues(), TreeNode.GetSubTreeWithDifferentValues());

            Console.WriteLine(result);
        }

        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;
            if (IsSameTree(root, subRoot)) return true;
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        
        private bool IsSameTree(TreeNode firstTree, TreeNode secondTree)
        {
            if (firstTree == null && secondTree == null) return true;
            if (firstTree == null || secondTree == null) return false;
        
            if (firstTree.val != secondTree.val) return false;

            return IsSameTree(firstTree?.left, secondTree?.left) &&
                   IsSameTree(firstTree?.right, secondTree?.right);
        }
    }
}