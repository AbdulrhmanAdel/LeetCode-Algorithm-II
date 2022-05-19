namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode GetTreeStaticValues()
        {
            return new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(2),
                },
                right = new TreeNode(5),
            };
        }
        
        public static TreeNode GetSubTreeWithStaticValues()
        {
            return new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(2),
            };
        }
        
        public static TreeNode GetSubTreeWithDifferentValues()
        {
            return new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(3),
            };
        }
    }
}