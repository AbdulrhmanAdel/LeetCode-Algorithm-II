namespace LeetCode
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

        public static Node BuildBinaryTree()
        {
            return new Node()
            {
                val = 1,
                left = new Node(2)
                {
                    left = new Node(4),
                    right = new Node(5)
                },
                right = new Node(3)
                {
                    right = new Node(7)
                    {
                    }
                },
            };
        }
    }
}