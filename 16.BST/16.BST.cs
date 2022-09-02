using System;
//C# program for binary search tree
class Node
{
	public int data;
	public Node left, right;
	public Node(int data)
	{
		this.data = data;
		left = null;
		right = null;
	}
}
class BST
{
	Node root;
	public BST()
	{
		this.root = null;
	}
	public BST(int data)
	{
		this.root = new Node(data);
	}
	public void insert(int data)
	{
		this.root = insertNode(this.root, data);
	}
	private Node insertNode(Node root, int data)
	{
		Node newNode = new Node(data);
		if (root == null)
		{
			return newNode;
		}
		else
		{
			if (data > root.data)
				root.right = insertNode(root.right, data);
			else
				root.left = insertNode(root.left, data);
            return root;
        }
    }
	public bool search(int data)
	{
		Node n = searchNode(this.root, data);
		if (n == null)
			return false;
		return true;
	}
    private Node searchNode(Node root,int data)
    {
        if (root == null || root.data == data)
            return root;
        if (root.data < data)
            return searchNode(root.right, data);
        return searchNode(root.left, data);
    }
	public void delete(int data)
	{
		this.root = deleteNode(this.root, data);
	}
	private Node deleteNode(Node root, int data)
	{
        if (root == null)
            return root;
        if (data < root.data)
            root.left = deleteNode(root.left, data);
        else if (data > root.data)
            root.right = deleteNode(root.right, data);
        else
        {
			if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;
            root.data = minValueInRightSubtree(root.right);
            root.right = deleteNode(root.right, root.data);
        }
        return root;
    }
    int minValueInRightSubtree(Node root)
    {
        int min = root.data;
        while (root.left != null)
        {
            min = root.left.data;
            root = root.left;
        }
        return min;
    }
    public void displayInorder()
	{
		inorderTraversal(this.root);
	}
	private void inorderTraversal(Node root)
	{
        if (root != null)
        {
            inorderTraversal(root.left);
            Console.WriteLine(root.data);
            inorderTraversal(root.right);
        }
    }
}

class Program
{
	public static void Main(string[] args)
	{
		BST bst = new BST();
		int choice,element;
		bool flag = true;
		while(flag)
		{
            Console.WriteLine("Please Enter Your Choice:\n1.Insert\t2.Search\t3.Delete\t4.Exit");
            choice = int.Parse(Console.ReadLine());
			switch(choice)
			{
				case 1:
					Console.WriteLine("Enter the element to be inserted:");
					element = int.Parse(Console.ReadLine());
					bst.insert(element);
					Console.WriteLine("After inserting {0}:-",element);
                    bst.displayInorder();
                    break;
				case 2:
                    Console.WriteLine("Enter the element to be searched:");
                    element = int.Parse(Console.ReadLine());
                    bool isPresent = bst.search(element);
					if (isPresent)
						Console.WriteLine("{0} is found in the Binary Search Tree", element);
					else
                        Console.WriteLine("{0} is not found in the Binary Search Tree", element);
                    break;
				case 3:
                    Console.WriteLine("Enter the element to be deleted:");
                    element = int.Parse(Console.ReadLine());
					if (bst.search(element))
					{
						bst.delete(element);
						Console.WriteLine("After deleting {0}:-", element);
						bst.displayInorder();
					}
					else
					{
						Console.WriteLine("Element not present in Binary Search Tree cannot be deleted");
                    }
                    break;
				case 4:
					flag = false;
					Console.WriteLine("Thank You!");
					break;
				default:
					Console.WriteLine("Invalid Choice!");
					break;
            }
        }
	}
}
