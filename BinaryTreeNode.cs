using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishCalculator
{
	class BinaryTreeNode
	{
		public string Data { get; } = null;
		public BinaryTreeNode ParentNode { get; } = null;
		public BinaryTreeNode LeftNode { get; set; } = null;
		public BinaryTreeNode RightNode { get; set; } = null;

		public override string ToString()
		{
			return (Data);
		}

		public BinaryTreeNode(BinaryTreeNode ParentNode, string Data)
		{
			this.ParentNode = ParentNode;
			this.Data = Data;
		}

		public void Insert(BinaryTreeNode LeftNode, BinaryTreeNode RightNode)
		{
			this.LeftNode = LeftNode;
			this.RightNode = RightNode;
		}
	}
}
