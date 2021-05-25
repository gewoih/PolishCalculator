using System;

namespace PolishCalculator
{
	class Program
	{
		public static void PrintTree(BinaryTreeNode root)
		{
			if (root != null)
			{
				PrintTree(root.LeftNode);
				PrintTree(root.RightNode);

				Console.WriteLine(root.Data);
			}
		}

		static void Main(string[] args)
		{
			BinaryTree Tree = new BinaryTree(new BinaryTreeNode(null, "/"));
			BinaryTreeNode node = Tree.RootNode;

			node.Insert(new BinaryTreeNode(node, "+"), new BinaryTreeNode(node, "-"));
			node = node.LeftNode;

			node.Insert(new BinaryTreeNode(node, "2"), new BinaryTreeNode(node, "*"));
			node = node.RightNode;

			node.Insert(new BinaryTreeNode(node, "5"), new BinaryTreeNode(node, "4"));
			node = Tree.RootNode.RightNode;

			node.Insert(new BinaryTreeNode(node, "/"), new BinaryTreeNode(node, "2"));
			node = node.LeftNode;

			node.Insert(new BinaryTreeNode(node, "8"), new BinaryTreeNode(node, "2"));

			PrintTree(Tree.RootNode);
		}
	}
}
