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
    }
}