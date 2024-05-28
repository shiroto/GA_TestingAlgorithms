using System;
using System.Collections.Generic;
using System.Linq;

public class MaxHeap<T> where T : IComparable
{
	private Node root;

	public int Count { get; private set; }

	public Node GetRoot()
	{
		return root;
	}

	public void Insert(T node)
	{
		Node insert = new() { value = node };
		if (root == null)
		{
			root = insert;
			return;
		}
		Append(insert);
		BubbleUp(insert);
		Count++;
	}

	private void Append(Node insert)
	{
		Queue<Node> queue = new();
		Node check = root;
		while (check != null)
		{
			if (check.leftChild == null)
			{
				check.SetLeftChild(insert);
				check = null;
			}
			else if (check.rightChild == null)
			{
				check.SetRightChild(insert);
				check = null;
			}
			else
			{
				queue.Enqueue(check.leftChild);
				queue.Enqueue(check.rightChild);

				if (queue.Count != 0)
				{
					check = queue.Dequeue();
				}
				else
				{
					check = null;
				}
			}
		}
	}

	private void BubbleUp(Node bubbleUp)
	{
		while (bubbleUp.parent != null && bubbleUp.value.CompareTo(bubbleUp.parent.value) > 0)
		{
			(bubbleUp.value, bubbleUp.parent.value) = (bubbleUp.parent.value, bubbleUp.value);
			bubbleUp = bubbleUp.parent;
		}
	}

	public T Extract()
	{
		if (root == null)
		{
			throw new InvalidOperationException();
		}
		T res = root.value;
		Node lastElement = FindLastElement();
		if (lastElement != root)
		{
			root.value = lastElement.value;
			if (lastElement.parent.leftChild == lastElement)
			{
				lastElement.parent.leftChild = null;
			}
			else
			{
				lastElement.parent.rightChild = null;
			}
			BubbleDown(root);
		}
		else
		{
			root = null;
		}
		Count--;
		return res;
	}

	private void BubbleDown(Node bubbleDown)
	{
		while (bubbleDown.rightChild != null && bubbleDown.leftChild != null)
		{
			Node smallerChild = bubbleDown.leftChild.value.CompareTo(bubbleDown.rightChild.value) > 0 ? bubbleDown.leftChild : bubbleDown.rightChild;
			Node biggerChild = bubbleDown.leftChild.value.CompareTo(bubbleDown.rightChild.value) <= 0 ? bubbleDown.leftChild : bubbleDown.rightChild;
			if (bubbleDown.value.CompareTo(smallerChild.value) < 0)
			{
				(bubbleDown.value, smallerChild.value) = (smallerChild.value, bubbleDown.value);
				bubbleDown = smallerChild;
			}
			else if (bubbleDown.value.CompareTo(biggerChild.value) < 0)
			{
				(bubbleDown.value, biggerChild.value) = (biggerChild.value, bubbleDown.value);
				bubbleDown = biggerChild;
			}
			else
			{
				break; // Smaller than children.
			}
		}
		if (bubbleDown.leftChild != null && bubbleDown.value.CompareTo(bubbleDown.leftChild.value) < 0)
		{
			(bubbleDown.value, bubbleDown.leftChild.value) = (bubbleDown.leftChild.value, bubbleDown.value);
		}
	}

	public Node FindLastElement()
	{
		if (root.leftChild == null && root.rightChild == null)
		{
			return root;
		}
		Queue<Node> queue = new();
		Node check = root;
		while (check != null)
		{
			if (check.leftChild == null)
			{
				return queue.Last();
			}
			else if (check.rightChild == null)
			{
				return check.leftChild;
			}
			else
			{
				queue.Enqueue(check.leftChild);
				queue.Enqueue(check.rightChild);

				if (queue.Count != 0)
				{
					check = queue.Dequeue();
				}
				else
				{
					check = null;
				}
			}
		}
		throw new Exception();
	}

	public class Node
	{
		public T value;
		public Node parent;
		public Node leftChild;
		public Node rightChild;

		public void SetLeftChild(Node n)
		{
			leftChild = n;
			n.parent = this;
		}

		public void SetRightChild(Node n)
		{
			rightChild = n;
			n.parent = this;
		}

	}
}
