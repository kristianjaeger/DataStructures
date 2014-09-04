using System;

namespace DataStructures
{
    class TreeNode
    {
	    public int Data;      
	    public TreeNode Left;    
	    public TreeNode Right; 
	    public TreeNode Parent;

	    public TreeNode(int number) 
        {
		    Data = number;
	    }
	
	    public void SetLeftChild(TreeNode left)
        {
		    Left = left;

		    if (left != null) 
            {
			    left.Parent = this;
		    }
	    }
	
	    public void SetRightChild(TreeNode right) 
        {
		    Right = right;
		
            if (right != null) 
            {
			    right.Parent = this;
		    }
	    }
	
	    public void InsertInOrder(int number) 
        {
		    if (number <= Data) 
            {
			    if (Left == null) 
                {
				    SetLeftChild(new TreeNode(number));
			    } 
                else 
                {
				    Left.InsertInOrder(number);
			    }
		    } 
            else 
            {
			    if (Right == null) 
                {
				    SetRightChild(new TreeNode(number));
			    }
                else
                {
				    Right.InsertInOrder(number);
			    }
		    }
	    }
	
	    public bool IsBst() 
        {
		    if (Left != null) 
            {
			    if (Data < Left.Data || !Left.IsBst()) 
                {
				    return false;
			    }
		    }
		
		    if (Right != null) 
            {
			    if (Data >= Right.Data || !Right.IsBst()) 
                {
				    return false;
			    }
		    }		
		
		    return true;
	    }
	
	    public int Height() 
        {
		    var leftHeight = Left != null ? Left.Height() : 0;
		    var rightHeight = Right != null ? Right.Height() : 0;

		    return 1 + Math.Max(leftHeight, rightHeight);
	    }
	
	    public TreeNode Find(int number) 
        {
		    if (number == Data) 
            {
			    return this;
		    } 
            else if (number <= Data) 
            {
			    return Left != null ? Left.Find(number) : null;
		    } 
            else if (number > Data) 
            {
			    return Right != null ? Right.Find(number) : null;
		    }

		    return null;
	    }
	
	    private static TreeNode AddToTree(int[] array, int start, int end)
        {
		    if (end < start) 
            {
			    return null;
		    }

		    var mid = (start + end) / 2;
		    var node = new TreeNode(array[mid]);
		    node.SetLeftChild(AddToTree(array, start, mid - 1));
		    node.SetRightChild(AddToTree(array, mid + 1, end));

		    return node;
	    }
	
	    public static TreeNode CreateMinimalBst(int[] array) 
        {
		    return AddToTree(array, 0, array.Length - 1);
	    }

        /*
         * Example code for Main method:
         *  Console.WriteLine(DateTime.Now.Millisecond);
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
         *
         * more helper methods:
         *public static int MaxDepth(TreeNode root)
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
         */
    }
}