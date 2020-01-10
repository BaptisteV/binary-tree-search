using System;

namespace TreeNode
{
    class Node
    {
        public Node right, left;

        public int value;

        private Node CheckChildren(int n)
        {
            if (left != null && left.value == n)
            {
                return left;
            }

            if (right != null && right.value == n)
            {
                return right;
            }

            // To check the tree deeper
            if(left != null)
            {
                return left;
            }
            return right;
        }

        public Node Find(int k)
        {
            if(value == k)
            {
                return this;
            }

            var children = CheckChildren(k);
            if (children?.value == k)
            {
                return children;
            }
            else if(children == null)
            {
                return null;
            }
            else
            {
                return children.Find(k);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var seven = new Node() { value = 7 };
            var three = new Node() { value = 3 };
            var five = new Node { value = 5, right = seven, left = three };

            var eleven = new Node { value = 11 };

            var nine = new Node { value = 9, right = eleven, left = five};

            Console.WriteLine(nine.Find(11).value); // 11
            Console.WriteLine(nine.Find(5).value); // 5
            Console.WriteLine(nine.Find(7).value); // 7
            Console.WriteLine(nine.Find(3).value); // 3

        }
    }
}
