using System;

namespace DataStructures
{
    class Program
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right));
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Min(MinDepth(root.Left), MinDepth(root.Right));
        }

        public static bool IsBalanced(TreeNode root)
        {
            return (MaxDepth(root) - MinDepth(root) <= 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

            // Create a balanced tree
		    int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		    var root = TreeNode.CreateMinimalBst(array);
		    Console.WriteLine("Root = " + root.Data);
		    Console.WriteLine("Balanced = " + IsBalanced(root));
		
		    // Create an unbalanced tree
		    var unbalanced = new TreeNode(10);
            var random = new Random();

		    for (var loopCounter = 0; loopCounter < 10; loopCounter++) 
            {
			    unbalanced.InsertInOrder(random.Next(0, 100));
		    }
		    Console.WriteLine("Root = " + unbalanced.Data);
            Console.WriteLine("Balanced = " + IsBalanced(unbalanced));

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
        }
    }
}